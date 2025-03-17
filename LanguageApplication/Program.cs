using System;
using LanguageApplication;
using Oracle.ManagedDataAccess.Client;

namespace Create_User
{
    class Program
    {
        //Set the net service name, Easy Connect, or connect descriptor of the pluggable DB, 
        // such as "localhost/XEPDB1" for 18c XE or higher
        public static string db = "<localhost/XEPDB1>";

        //Provide the DBA's user id, password, and role to create the demo user
        //If admin has no role, then set to empty string
        public static string sysUser = "tam22032004";
        public static string sysPwd = "tam22032004";
        public static string role = "";

        //Set the demo user id, such as DEMODOTNET and password
        public static string user = "<DEMODOTNET>";
        public static string pwd = "<PASSWORD>";

        static void Main()
        {
            //Create connection string. Check whether DBA Privilege is required.
            string conStringDBA;
            if (role == "")
                conStringDBA = "User Id=" + sysUser + ";Password=" + sysPwd + ";Data Source=" + db + ";";
            else
                conStringDBA = "User Id=" + sysUser + ";Password=" + sysPwd + ";DBA Privilege=" + role + ";Data Source=" + db + ";";

            using (OracleConnection con = new OracleConnection(conStringDBA))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Successfully connected to Oracle Database");
                        Console.WriteLine();

     

                        //Modify the anonymous PL/SQL GRANT command if you wish to modify the privileges granted
                        cmd.CommandText = "BEGIN " +
                            "EXECUTE IMMEDIATE ('CREATE USER " + user + " IDENTIFIED BY " + pwd +
                              " DEFAULT TABLESPACE USERS QUOTA UNLIMITED ON USERS'); " +
                            "EXECUTE IMMEDIATE ('GRANT CREATE SESSION, CREATE VIEW, CREATE SEQUENCE, CREATE PROCEDURE, " +
                               "CREATE TABLE, CREATE TRIGGER, CREATE TYPE, CREATE MATERIALIZED VIEW TO " + user + "'); " +
                            "END;";
                        cmd.ExecuteNonQuery();
                        ApplicationConfiguration.Initialize();
                        Application.Run(new frmTrangChu());

                        Console.WriteLine(user + " user created");
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        ApplicationConfiguration.Initialize();
                        Application.Run(new frmTrangChu());
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}