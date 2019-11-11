using Advantage.Data.Provider;
using BulkSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS.Data
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly Connection _conn;
        private DataTable dt;
        public CustomerRepository(Connection conn)
        {
            _conn = conn;
            var database = new Database(_conn);
            database.CreateDatabase();
        }
        public void AddCustomer(Customer customer)
        {
            SqlConnection con = _conn.GetSqlConnection();

            var str = "INSERT INTO Customers (FirstName,LastName,Gender,Address,City,Country,Telephone,Email,Debt) Values('"
                    + customer.FirstName +"','"
                    + customer.LastName +"','"
                    + customer.Gender + "','"
                    + customer.Address + "','"
                    + customer.City + "','"
                    + customer.Country + "','"
                    + customer.Telephone +"','"
                    + customer.Email +"',"
                    + customer.Debt +")";

            con.Open();
            var cmd = new SqlCommand(str, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public DataTable GetCustomers()
        {
            var str = "SELECT * FROM Customers";
            SqlConnection con = _conn.GetSqlConnection();
            var cmd = new SqlCommand(str, con);
            try
            {
                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void DeleteCustomer(int id)
        {
            SqlConnection con = _conn.GetSqlConnection();

            var str = "DELETE FROM Customers WHERE Id=" + id;

            con.Open();
            var cmd = new SqlCommand(str, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
