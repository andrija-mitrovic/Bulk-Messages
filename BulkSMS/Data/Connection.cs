using Advantage.Data.Provider;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkSMS.Data
{
    public class Connection
    {
        public static string _sqlsstr = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        public static string _constm = ConfigurationManager.ConnectionStrings["Local"]
                .ConnectionString.Replace("Focus", "master");
        public static string _const = ConfigurationManager.ConnectionStrings["Local"]
                .ConnectionString.Replace("Focus", "Test");

        public SqlConnection GetSqlConnectionMaster()
        {
            SqlConnection con = new SqlConnection(Connection._constm);
            return con;
        }

        public SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection(Connection._const);
            return con;
        }
    }
}
