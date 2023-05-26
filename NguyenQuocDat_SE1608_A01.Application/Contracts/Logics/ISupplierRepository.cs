using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Core.Interfaces
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplierById(int id);
        void AddSupplier(Supplier order);
        void UpdateSupplier(Supplier order);
        void DeleteSupplier(int id);
    }
}
