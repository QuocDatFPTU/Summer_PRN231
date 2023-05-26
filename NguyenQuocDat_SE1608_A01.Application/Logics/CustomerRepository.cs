using NguyenQuocDat_SE1608_A01.Application.Contracts.Data;
using NguyenQuocDat_SE1608_A01.Application.Contracts.Logics;
using NguyenQuocDat_SE1608_A01.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Application.Logics
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IFUFlowerBouquetManagementContext _dbContext;
        public CustomerRepository(IFUFlowerBouquetManagementContext context)
        {
            _dbContext = context;
        }
        public void AddCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            var listCustomers = new List<CustomerDto>();
            try
            {
                listCustomers = _dbContext.Customers.Select(_ => new CustomerDto { 
                    CustomerId = _.CustomerId,
                    Birthday = _.Birthday,
                    City = _.City,
                    Country = _.Country,
                    CustomerName = _.CustomerName,
                    Email = _.Email,
                    Password = _.Password
                }).ToList();
                return listCustomers;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }

        public CustomerDto GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }


        public CustomerDto SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
