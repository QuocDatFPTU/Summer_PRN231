using Microsoft.EntityFrameworkCore;
using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Application.Contracts.Data
{
    public interface IFUFlowerBouquetManagementContext
    {
        public DbSet<Customer> Customers { get; }
    }
}
