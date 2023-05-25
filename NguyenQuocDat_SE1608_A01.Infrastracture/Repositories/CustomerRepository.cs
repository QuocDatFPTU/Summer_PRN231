using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Core.Interfaces
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            var listCustomers = new List<Customer>();
            try
            {
                using(var context = new FUFlowerBouquetManagementContext())
                {
                    listCustomers = context.Customers.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        return listCustomers;
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
