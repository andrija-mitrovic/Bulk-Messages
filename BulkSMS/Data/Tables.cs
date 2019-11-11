using BulkSms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkSMS.Data
{
    public class Tables
    {
        public static void CreateTables()
        {
            CustomerTable customer = new CustomerTable("Customers");
        }
    }
    //Table Definitions
   class CustomerTable
   {
       public CustomerTable(string nazivTabele)
       {
           string[,] tabela =
           new string[,] {   
                         { "Id",        "int",      "IDENTITY(1,1) PRIMARY KEY"},
                         { "FirstName", "varchar(30)"     ,  "DEFAULT ''"},
                         { "LastName",  "varchar(30)"     ,  "DEFAULT ''"},
                         { "Gender",    "varchar(30)",       "DEFAULT ''"},
                         { "Address",   "varchar(30)",       "DEFAULT ''"},
                         { "City",      "varchar(30)",       "DEFAULT ''"},
                         { "Country",   "varchar(30)",       "DEFAULT ''"},
                         { "Telephone", "varchar(30)",               "DEFAULT ''" },
                         { "Email",     "varchar(30)",       "DEFAULT ''"},
                         { "Debt",      "float",             "DEFAULT 0.00"} };

           CRT create = new CRT(tabela, nazivTabele);
       }
   }
}
