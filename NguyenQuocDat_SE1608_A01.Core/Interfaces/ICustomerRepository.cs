using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Customer SignIn(string email, string password);
        IEnumerable<Customer> GetAll();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
