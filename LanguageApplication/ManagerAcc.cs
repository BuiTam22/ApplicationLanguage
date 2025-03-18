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
    public partial class ManagerAcc : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
        public ManagerAcc()
        {
            InitializeComponent();
        }
        private void LoadAccounts()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT ID, USERNAME, PASSWORD, NAME, EMAIL, ROLE FROM AppUser";
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvManagerAcc.DataSource = dt;
                if (dgvManagerAcc.Columns["ID"] != null)
                {
                    dgvManagerAcc.Columns["ID"].Visible = false;
                }
                if (dgvManagerAcc.Columns["STT"] == null)
                {
                    DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                    sttColumn.Name = "STT";
                    sttColumn.HeaderText = "STT";
                    dgvManagerAcc.Columns.Insert(0, sttColumn);
                }
                for (int i = 0; i < dgvManagerAcc.Rows.Count; i++)
                {
                    dgvManagerAcc.Rows[i].Cells["STT"].Value = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ManagerAcc_Load(object sender, EventArgs e)
        {
            conn = KetNoi.connectDB();
            LoadAccounts();
           
        }

        private void dgvManagerAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManagerAcc.Rows[e.RowIndex];

                // Lấy dữ liệu từ hàng được chọn
                string id = row.Cells["ID"].Value.ToString();
                string username = row.Cells["USERNAME"].Value.ToString();
                string password = row.Cells["PASSWORD"].Value.ToString();
                string name = row.Cells["NAME"].Value != DBNull.Value ? row.Cells["NAME"].Value.ToString() : "";
                string email = row.Cells["EMAIL"].Value != DBNull.Value ? row.Cells["EMAIL"].Value.ToString() : "";
                string role = row.Cells["ROLE"].Value.ToString();
                EditUser editForm = new EditUser(id, username, password, name, email, role);
                editForm.ShowDialog();
            }
        }
    }
}
