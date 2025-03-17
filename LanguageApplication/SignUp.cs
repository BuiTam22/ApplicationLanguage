using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LanguageApplication
{
    public partial class SignUp : Form
    {
        public static string currentUser;
        private frmTrangChu mainForm;
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox trên Form
            string userName = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            string re_enterpassword = txtReEnterPassWord.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(re_enterpassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Kiểm tra xem username đã tồn tại hay chưa
                string sqlCheckUserName = "SELECT COUNT(*) FROM AppUser WHERE UserName = :userName";
                using (OracleCommand cmd = new OracleCommand(sqlCheckUserName, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("userName", userName));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Nếu username chưa tồn tại, thực hiện đăng ký
                int idNew = GetNextId();
                string sqlInsert = "INSERT INTO AppUser (Id, UserName, Password) VALUES (:id, :userName, :password)";

                using (OracleCommand cmdInsert = new OracleCommand(sqlInsert, conn))
                {
                    cmdInsert.Parameters.Add(new OracleParameter("id", idNew));
                    cmdInsert.Parameters.Add(new OracleParameter("userName", userName));
                    cmdInsert.Parameters.Add(new OracleParameter("password", password));  // Cần mã hóa mật khẩu trước khi lưu

                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //// Chuyển về Form Login
                //Login theLogIn = new Login();
                //theLogIn.Show();
                this.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetNextId()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT NVL(MAX(id), 0) + 1 FROM AppUser";
                OracleCommand cmd = new OracleCommand(sql, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return -1;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
        }
    }
}