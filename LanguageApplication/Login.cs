﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class Login : Form
    {
        public static string currentUser;
        private frmTrangChu mainForm = new frmTrangChu();
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        String username = "";
        public Login(frmTrangChu form)
        {
            InitializeComponent();
            mainForm = form;  // Nhận tham chiếu tới Form1 hiện tại
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để bật mntFeature trên form chính
            // Viết mã Sql Truy vấn User hợp lệ

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                 username = txtUserName.Text.Trim();
                string password = txtPassWord.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql = "SELECT ROLE FROM AppUser WHERE UserName = :username AND PassWord = :password";
                cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("username", username));
                cmd.Parameters.Add(new OracleParameter("password", password));

                object roleObj = cmd.ExecuteScalar();

                if (roleObj != null)
                {
                    string role = roleObj.ToString().Trim().ToLower();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentUser = username;
                    mainForm.setMntFeatureEnableTrue();
                    mainForm.UpdateUserName(username);
                    if (role == "admin")
                    {
                        mainForm.EnableAccountManagement(true); 
                    }
                    else
                    {
                        mainForm.EnableAccountManagement(false);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp theSignUp = new SignUp();
            theSignUp.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            conn = KetNoi.connectDB();
        }
    }
}
