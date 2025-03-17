using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LanguageApplication
{
    class KetNoi
    {
        public static OracleConnection connectDB()
        {
            // Data source là Ip của máy
            string connString = "User Id=tam22032004; Password=tam22032004; Data Source= 192.168.56.1";
            OracleConnection conn = new OracleConnection(connString);

            return conn;

        }

    }
}
