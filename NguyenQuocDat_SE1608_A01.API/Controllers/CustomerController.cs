using Microsoft.AspNetCore.Mvc;
using NguyenQuocDat_SE1608_A01.Core.Interfaces;
using NguyenQuocDat_SE1608_A01.Core.Entities;
using System.Collections;

namespace NguyenQuocDat_SE1608_A01.API.Controllers
{
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository repo = new CustomerRepository();
        
        public ActionResult<IEnumerable<Customer>> GetCustomer()=> repo.GetAll();
    }
}
