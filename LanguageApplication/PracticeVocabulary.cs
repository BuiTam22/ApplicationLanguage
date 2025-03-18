using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageApplication
{
    public partial class PracticeVocabulary : Form
    {
        private int score = 0;
        private string idTopic;
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        private List<(string englishWord, string vietnameseWord)> vocabularyList = new List<(string, string)>();
        private int currentIndex = 0;
        private Random random = new Random();


        public PracticeVocabulary(string idTopic)
        {
            this.idTopic = idTopic;
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PracticeVocabulary_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                sql = "SELECT v.englishWord, v.vietnamWord FROM Vocabulary v WHERE v.IDTOPIC = :idTopic";

                da = new OracleDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new OracleParameter("idTopic", idTopic));
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Lưu dữ liệu vào danh sách
                    foreach (DataRow row in dt.Rows)
                    {
                        vocabularyList.Add((row["englishWord"].ToString(), row["vietnamWord"].ToString()));
                    }

                    // Xáo trộn thứ tự từ vựng
                    vocabularyList = vocabularyList.OrderBy(x => random.Next()).ToList();

                    // Hiển thị từ đầu tiên
                    DisplayNextWord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void DisplayNextWord()
        {
            if (currentIndex < vocabularyList.Count)
            {
                txtVietnameseWord.Text = vocabularyList[currentIndex].vietnameseWord;
                txtEnglishWord.Clear();
                lblResuit.Text = "Result:";
            }
            else
            {
                MessageBox.Show("Hoàn thành bài tập" + " với số điểm: " + this.score + "/" + vocabularyList.Count, "Thông báo");
                btnSubmit.Enabled = false;
            }
        }



        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < vocabularyList.Count)
            {
                string userAnswer = txtEnglishWord.Text.Trim().ToLower();
                string correctAnswer = vocabularyList[currentIndex].englishWord.ToLower();

                if (userAnswer == correctAnswer)
                {
                    lblResuit.Text = "✔ Correct!";
                    lblResuit.ForeColor = Color.Green;
                    this.score += 1;
                }
                else
                {
                    lblResuit.Text = $"✘ Incorrect! Correct: {vocabularyList[currentIndex].englishWord}";
                    lblResuit.ForeColor = Color.Red;
                }

                currentIndex++;
                Task.Delay(1000).ContinueWith(t => Invoke(new Action(DisplayNextWord))); // Hiển thị từ tiếp theo
            }
        }
    }
}
