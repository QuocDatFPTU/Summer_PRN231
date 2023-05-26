using Microsoft.AspNetCore.Mvc;

using System.Collections;
using System.Collections.Generic;
using NguyenQuocDat_SE1608_A01.Application.Contracts.Logics;

namespace NguyenQuocDat_SE1608_A01.API.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerLogic;
       
        public CustomerController(ICustomerRepository customerLogic)
        {
            _customerLogic = customerLogic; 
        }
        [HttpGet]
        [Route("all-customers")]
        public ActionResult GetCustomer() 
        {
            return Ok(_customerLogic.GetAll());
                
        }
    }
}
