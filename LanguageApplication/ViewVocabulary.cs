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
using System.Xml.Linq;

namespace LanguageApplication
{
    public partial class ViewVocabulary : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        String username = "";
        string idTopic = "";
        public ViewVocabulary()
        {
            InitializeComponent();
        }
        public ViewVocabulary(string idTopic)
        {
           
            this.idTopic = idTopic;
            InitializeComponent();
        }
        private void ViewVocabulary_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            LoadVocabulary();
        }
        private void LoadVocabulary()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT v.id, v.englishWord, v.vietnamWord, v.transcription, t.NAMETOPIC, w.nameWordType,v.idWordType,v.idTopic " +
                "FROM Vocabulary v " +
                "JOIN Topic t ON v.IDTOPIC = t.id " +
                "JOIN WordType w ON v.idWordType = w.id " +
                 "WHERE v.IDTOPIC = :idTopic";

                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(new OracleParameter("idTopic", idTopic));

                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("STT", typeof(int));

                //Gán số thứ tự từ 1 đến n
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }

                dgvVocabulary.DataSource = dt;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void CustomizeDataGridView()
        {
            dgvVocabulary.Columns["STT"].DisplayIndex = 0; // Đưa cột STT lên đầu
            dgvVocabulary.Columns["STT"].HeaderText = "STT";
            dgvVocabulary.Columns["STT"].Width = 50;
            dgvVocabulary.Columns["STT"].ReadOnly = true; // Không cho phép chỉnh sửa
            dgvVocabulary.Columns["id"].Visible = false;

            dgvVocabulary.Columns["englishWord"].HeaderText = "Từ Tiếng Anh";
            dgvVocabulary.Columns["vietnamWord"].HeaderText = "Từ Tiếng Việt";
            dgvVocabulary.Columns["transcription"].HeaderText = "Phiên Âm";
            dgvVocabulary.Columns["nameTopic"].HeaderText = " Chủ Đề";
            dgvVocabulary.Columns["nameWordType"].HeaderText = " Loại Từ";
            dgvVocabulary.Columns["idWordType"].Visible = false;
            dgvVocabulary.Columns["idTopic"].Visible = false;
            dgvVocabulary.Columns["id"].Width = 50;
            dgvVocabulary.Columns["englishWord"].Width = 150;
            dgvVocabulary.Columns["vietnamWord"].Width = 150;
            dgvVocabulary.Columns["transcription"].Width = 100;

            dgvVocabulary.Columns["id"].ReadOnly = true; // Không cho sửa ID
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgvVocabulary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVocabulary.Rows[e.RowIndex];

                // Hiển thị dữ liệu vào các TextBox
                string id = row.Cells["id"].Value.ToString();
                string englishWord = row.Cells["englishWord"].Value.ToString();
                string vietnamWord = row.Cells["vietnamWord"].Value.ToString();
                string transcription = row.Cells["transcription"].Value.ToString();
                string idTopic = row.Cells["idTopic"].Value.ToString();
                string idWordType = row.Cells["idWordType"].Value.ToString();
                EditVocabulary edit = new EditVocabulary( id, englishWord, vietnamWord, transcription, idTopic, idWordType);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    LoadVocabulary();
                }
            }
        }

    }
}
