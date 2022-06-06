using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
   public interface IVegetable
    {
        public string SaveVegetable(vegetableDetails vegetable);
        public string UpdateVegetable(vegetableDetails vegetable);
        public string DeleteVegetable(int VegetableID);
        vegetableDetails GetVegetable(int VegetableID);
        List<vegetableDetails> GetAllVegetables();
    }
}
