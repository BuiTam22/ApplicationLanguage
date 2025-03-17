using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LanguageApplication
{
    public partial class TopicDaHoc : Form
    {
        private frmTrangChu mainForm;
        private Login login;
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        DataTable dt;
        string sql = "";
        public TopicDaHoc()
        {
            InitializeComponent();
        }

        private void TopicDaHoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }
        private void LoadComboBoxData()
        {
            txtid.ReadOnly = true;
            conn = KetNoi.connectDB();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT nameTopic FROM Topic WHERE userNameCreated = :currentUser";
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("currentUser", Login.currentUser));
                OracleDataReader reader = cmd.ExecuteReader();
                cbtopic.Items.Clear();

                while (reader.Read())
                {
                    cbtopic.Items.Add(reader["nametopic"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameTopic.Text))
            {
                MessageBox.Show("Vui lòng nhập tên topic!");
                return;
            }

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                int newId = GetNextId();
                if (newId == -1) return;

                string sql = "INSERT INTO Topic(id, userNameCreated, nameTopic, description) VALUES (:id, :userNameCreated, :nameTopic, :description)";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("id", newId));
                cmd.Parameters.Add(new OracleParameter("userNameCreated", Login.currentUser));
                cmd.Parameters.Add(new OracleParameter("nameTopic", txtNameTopic.Text));
                cmd.Parameters.Add(new OracleParameter("description", txtdescription.Text));

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadComboBoxData(); // Cập nhật danh sách
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbtopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string selectedTopic = cbtopic.SelectedItem.ToString();
                string sql = "SELECT * FROM Topic WHERE nameTopic = :nameTopic";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("nameTopic", selectedTopic));

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid.Text = reader["id"].ToString();
                    txtuserNameCreated.Text = reader["userNameCreated"].ToString();
                    txtNameTopic.Text = reader["nameTopic"].ToString();
                    txtdescription.Text = reader["description"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "UPDATE Topic SET userNameCreated = :userNameCreated, nameTopic = :nameTopic, description = :description WHERE id = :id";

                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(new OracleParameter("userNameCreated", txtuserNameCreated.Text));
                cmd.Parameters.Add(new OracleParameter("nameTopic", txtNameTopic.Text));
                cmd.Parameters.Add(new OracleParameter("description", txtdescription.Text));
                cmd.Parameters.Add(new OracleParameter("id", txtid.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadComboBoxData();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Topic này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Topic WHERE id = :id";

                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(new OracleParameter("id", txtid.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadComboBoxData();
                        ClearTextBoxes(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtuserNameCreated.Clear();
            txtNameTopic.Clear();
            txtdescription.Clear();
        }
        private int GetNextId()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT NVL(MAX(id), 0) + 1 FROM Topic";
                OracleCommand cmd = new OracleCommand(sql, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopicDetail topicDetail = new TopicDetail(txtid.Text);
           
            topicDetail.Show();
            
        }
    }
}
