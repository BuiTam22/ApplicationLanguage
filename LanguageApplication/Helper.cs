using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageApplication
{
    class Helper
    {
        OracleConnection conn;
        OracleDataAdapter da;
        OracleCommand cmd;
       public Helper()
        {
            this.conn=KetNoi.connectDB();
        }
        public int GetNextId(string nameObject)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "SELECT NVL(MAX(TO_NUMBER(id)), 0) + 1 FROM "+nameObject;
                OracleCommand cmd = new OracleCommand(sql, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return -1;
            }
        }
    }
}
