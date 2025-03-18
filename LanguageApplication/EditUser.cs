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
    public partial class EditUser : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        public EditUser()
        {
            InitializeComponent();
        }
        public EditUser(string id, string username, string password, string name, string email, string role)
        {
            InitializeComponent();

            // Đưa dữ liệu vào các TextBox
            txtid.Text = id;
            txtusername.Text = username;
            txtpass.Text = password;
            txtname.Text = name;
            txtemail.Text = email;
            cbRole.Items.Add("admin");
            cbRole.Items.Add("user");
            if (cbRole.Items.Contains(role))
            {
                cbRole.SelectedItem = role;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Helper helper = new Helper();
                int newId = helper.GetNextId("AppUser");
                string sql = "INSERT INTO AppUser (ID, USERNAME, PASSWORD, NAME, EMAIL, ROLE) VALUES (:id, :username, :password, :name, :email, :role)";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = newId;
                cmd.Parameters.Add(new OracleParameter("username", txtusername.Text));
                cmd.Parameters.Add(new OracleParameter("password", txtpass.Text));
                cmd.Parameters.Add(new OracleParameter("name", txtname.Text));
                cmd.Parameters.Add(new OracleParameter("email", txtemail.Text));
                cmd.Parameters.Add(new OracleParameter("role", cbRole.SelectedItem.ToString()));

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Thêm tài khoản thành công!");
                else
                    MessageBox.Show("Thêm tài khoản thất bại!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE AppUser SET PASSWORD = :password, NAME = :name, EMAIL = :email, ROLE = :role WHERE USERNAME = :username";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("password", txtpass.Text));
                cmd.Parameters.Add(new OracleParameter("name", txtname.Text));
                cmd.Parameters.Add(new OracleParameter("email", txtemail.Text));
                cmd.Parameters.Add(new OracleParameter("role", cbRole.SelectedItem.ToString()));
                cmd.Parameters.Add(new OracleParameter("username", txtusername.Text));

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                else
                    MessageBox.Show("Không tìm thấy tài khoản!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "DELETE FROM AppUser WHERE USERNAME = :username";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(new OracleParameter("username", txtusername.Text));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
