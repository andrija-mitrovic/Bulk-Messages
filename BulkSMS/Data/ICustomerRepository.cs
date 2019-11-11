using BulkSMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkSMS.Data
{
    public interface ICustomerRepository
    {
        DataTable GetCustomers();
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
