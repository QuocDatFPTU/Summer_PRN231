using NguyenQuocDat_SE1608_A01.Core.Entities;
using System.Collections.Generic;
using System;

namespace NguyenQuocDat_SE1608_A01.API.Dtos
{
    public class CustomerDto
    {
        public CustomerDto()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
