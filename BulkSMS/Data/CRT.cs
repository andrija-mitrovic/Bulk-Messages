using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BulkSMS.Data;

namespace BulkSms.Data
{
    public class CRT
    {
        private SqlConnection con;
        private SqlCommand sqlCom;

        public CRT(string[,] table, string nazivTabele)
        {
            string tmpTable = nazivTabele + "_tmp";

            string CreateTable = "CREATE TABLE " + nazivTabele + " (";
            string tmpCreateTable = "CREATE TABLE " + tmpTable + " (";

            int heightTable = table.GetLength(0);
            int widthTable = table.GetLength(1);

            for (int i = 0; i < heightTable; i++)
            {
                for (int j = 0; j < widthTable; j++)
                {
                    CreateTable += " " + table[i, j];
                    tmpCreateTable += " " + table[i, j];
                }
                CreateTable += ",";
                tmpCreateTable += ",";
            }
            CreateTable = CreateTable.Substring(0, CreateTable.Length - 1) + ")";
            tmpCreateTable = tmpCreateTable.Substring(0, tmpCreateTable.Length - 1) + ")";

            Connection conn = new Connection();
            con = conn.GetSqlConnection();

            try
            {
                con.Open();

                if (TableFound(con, nazivTabele))
                {
                    sqlCom = new SqlCommand(tmpCreateTable, con);
                    sqlCom.ExecuteNonQuery();

                    string insColumns = InsertColumns(con, nazivTabele, table);

                    sqlCom = new SqlCommand("INSERT INTO " + tmpTable + "(" + insColumns + ")" + " SELECT " + insColumns + " FROM " + nazivTabele, con);
                    sqlCom.ExecuteNonQuery();

                    sqlCom = new SqlCommand("DROP TABLE " + nazivTabele, con);
                    sqlCom.ExecuteNonQuery();

                    sqlCom = new SqlCommand(@"EXEC sp_rename " + tmpTable + " , " + nazivTabele, con);
                    sqlCom.ExecuteNonQuery();

                }
                else
                {
                    sqlCom = new SqlCommand(CreateTable, con);
                    sqlCom.ExecuteNonQuery();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private string InsertColumns(SqlConnection con, string nazivTabele, string[,] table)
        {

            string columnNumber = @"SELECT COLUMN_NAME, DATA_TYPE
                    FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = N'" + nazivTabele + "'";

            string insertColumns = "";

            SqlCommand sqlCom = new SqlCommand(columnNumber, con);
            SqlDataReader reader;
            reader = sqlCom.ExecuteReader();
            List<string> tableCol = new List<string>();

            while (reader.Read())
            {
                tableCol.Add(reader["COLUMN_NAME"].ToString().ToLower());
            }
            reader.Close();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (tableCol.Contains(table[i, 0]))
                {
                    insertColumns += table[i, 0] + ",";
                }
            }

            insertColumns = insertColumns.Substring(0, insertColumns.Length - 1);

            return insertColumns;

        }

        private bool TableFound(SqlConnection con, string mTable)
        {
            Int32 mFound = 0;
            string sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('[dbo].[" + mTable + "]')";
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {

                    mFound = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return mFound == 1 ? true : false;

        }      

    }

}

