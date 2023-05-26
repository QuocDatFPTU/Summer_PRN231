using NguyenQuocDat_SE1608_A01.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Application.Contracts.Logics
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerDto> GetAll();
        CustomerDto GetCustomerById(int id);
        void AddCustomer(CustomerDto order);
        void UpdateCustomer(CustomerDto order);
        void DeleteCustomer(int id);
    }
}
