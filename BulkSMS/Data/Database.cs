using BulkSms.Data;
using BulkSMS.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS.Data
{
    public class Database
    {
        private Connection _conn;
        private static SqlCommand cmd;
        private static string _dbPath;
        private static string _datab;
        private static string focusdb;
        public Database(Connection conn)
        {
            _conn = conn;
            _datab = ConfigurationManager.AppSettings["dbName"];
        }
        public void CreateDatabase()
        {
            var str = "SELECT * FROM master.dbo.sysdatabases WHERE name = '"+ 
                    ConfigurationManager.AppSettings["dbName"] +"'";
            
            bool isExist = false;
            using (var con = _conn.GetSqlConnectionMaster())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isExist = reader.HasRows;
                        }
                    }
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("SQL server is not available...", "Attention!");
                }
            }

            if (!isExist)
            {
                DialogResult response = MessageBox.Show("Database Test doesn't exist, Creating...", "Attention !", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            _dbPath = fbd.SelectedPath;
                            focusdb = "CREATE DATABASE " + _datab + " ON PRIMARY " +
                                    "(NAME = " + _datab + "Data, " +
                                    "FILENAME = '" + _dbPath + _datab + ".mdf', " +
                                    "SIZE = 800MB, MAXSIZE = 1000MB, FILEGROWTH = 10%) " +
                                    "LOG ON (NAME = " + _datab + "Log, " +
                                    "FILENAME = '" + _dbPath + _datab + ".ldf', " +
                                    "SIZE = 800MB, " +
                                    "MAXSIZE = 1000MB, " +
                                    "FILEGROWTH = 10%)";

                            try
                            {
                                CreateDb();
                                CreateTb();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
        }

        public void CreateDb()
        {
            var sqlconm = _conn.GetSqlConnectionMaster();
            cmd = new SqlCommand(focusdb, sqlconm);
            try
            {
                sqlconm.Open();
                cmd.ExecuteNonQuery();
                sqlconm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Server not available ..." + ex, "Attention!");
                return;
            }
        }

        public void CreateTb()
        {
            Tables.CreateTables();
        }
    }

   
}
