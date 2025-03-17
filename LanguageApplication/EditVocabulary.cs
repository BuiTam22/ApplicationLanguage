using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace LanguageApplication
{
    public partial class EditVocabulary : Form
    {
        private OracleConnection conn;
        private string action;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public EditVocabulary()
        {
            InitializeComponent();
        }
        public EditVocabulary(string id, string EnglishWord, string VietnamWord, string Transcription, string idTopic, string idWordType)
        {
            InitializeComponent(); // Khởi tạo giao diện trước

            conn = KetNoi.connectDB(); // Khởi tạo kết nối với CSDL

            LoadTopics(); // Hàm tải danh sách chủ đề vào ComboBox
            LoadWordTypes();

            txtid.Text = id;
            txtEnglishWord.Text = EnglishWord;
            txtVietnamWord.Text = VietnamWord;
            txtTranscription.Text = Transcription;

            cbTitleTopic.SelectedValue = idTopic; // Chọn đúng chủ đề dựa trên ID
            cbTitleWordType.SelectedValue = idWordType;
        }
        private void EditVocabulary_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối chưa được khởi tạo!");
                    return;
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                Helper helper = new Helper();
                int newId =helper.GetNextId("Vocabulary"); // Gọi hàm lấy ID mới

                string sql = "INSERT INTO Vocabulary (id, englishWord, vietnamWord, transcription, idTopic, idWordType) " +
                             "VALUES (:id, :englishWord, :vietnamWord, :transcription, :idTopic, :idWordType)";
                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(":id", newId);
                cmd.Parameters.Add(":englishWord", txtEnglishWord.Text);
                cmd.Parameters.Add(":vietnamWord", txtVietnamWord.Text);
                cmd.Parameters.Add(":transcription", txtTranscription.Text);
                cmd.Parameters.Add(":idTopic", cbTitleTopic.SelectedValue);
                cmd.Parameters.Add(":idWordType", cbTitleWordType.SelectedValue);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        

        private void LoadTopics()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Lọc chỉ các chủ đề của user hiện tại
                string sql = "SELECT id, nameTopic FROM Topic WHERE userNameCreated = :currentUser";
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add(":currentUser", Login.currentUser);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTitleTopic.DataSource = dt;
                cbTitleTopic.DisplayMember = "nameTopic"; // Hiển thị tên chủ đề
                cbTitleTopic.ValueMember = "id"; // Lưu giá trị là ID chủ đề
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chủ đề: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void LoadWordTypes()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT id, nameWordType FROM WordType";
                OracleCommand cmd = new OracleCommand(sql, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có loại từ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cbTitleWordType.DataSource = dt;
                cbTitleWordType.DisplayMember = "nameWordType"; // Hiển thị tên loại từ
                cbTitleWordType.ValueMember = "id"; // Lưu giá trị là ID loại từ
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại từ: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "UPDATE Vocabulary SET englishWord = :englishWord, vietnamWord = :vietnamWord, " +
                             "transcription = :transcription, idTopic = :idTopic, idWordType = :idWordType " +
                             "WHERE id = :id";

                OracleCommand cmd = new OracleCommand(sql, conn);

                cmd.Parameters.Add(":englishWord", txtEnglishWord.Text);
                cmd.Parameters.Add(":vietnamWord", txtVietnamWord.Text);
                cmd.Parameters.Add(":transcription", txtTranscription.Text);
                cmd.Parameters.Add(":idTopic", cbTitleTopic.SelectedValue);
                cmd.Parameters.Add(":idWordType", cbTitleWordType.SelectedValue);
                cmd.Parameters.Add(":id", txtid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK; // Gửi kết quả thành công về ViewVocabulary
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Không có từ vựng nào để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá từ vựng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql = "DELETE FROM Vocabulary WHERE id = :id";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(":id", txtid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xoá thành công!");
                        this.DialogResult = DialogResult.OK; // Để ViewVocabulary cập nhật danh sách
                        this.Close(); // Đóng form EditVocabulary
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
