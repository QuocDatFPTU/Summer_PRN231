using NguyenQuocDat_SE1608_A01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenQuocDat_SE1608_A01.Core.Interfaces
{
    public interface IFlowerBouquetRepository
    {
        IEnumerable<FlowerBouquet> GetAll();
        FlowerBouquet GetFlowerBouquetById(int id);
        void AddFlowerBouquet(FlowerBouquet flower);
        void UpdateFlowerBouquet(FlowerBouquet flower);
        void DelteFlowerBouquet(int id);
    }
}
