using GreenFreggies.API.Models;
using GreenFreggies.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Services
{
    public class VegetableServices
    {
        private IVegetable _vegetableRepository;
        public VegetableServices(IVegetable vegetableRepository)
        {
             _vegetableRepository=vegetableRepository;
        }
        public string SaveVegetable(vegetableDetails vegetableDetails)
        {
            return _vegetableRepository.SaveVegetable(vegetableDetails);
        }
        public string DeleteVegetable(int VegetableID)
        {
            return _vegetableRepository.DeleteVegetable(VegetableID);
        }
        public string UpdateVegetable(vegetableDetails vegetableDetails)
        {
            return _vegetableRepository.UpdateVegetable(vegetableDetails);
        }
        public vegetableDetails GetVegetable(int VegetableID)
        {
            return _vegetableRepository.GetVegetable(VegetableID);
        }
        public List<vegetableDetails> GetAllVegetables()
        {
            return _vegetableRepository.GetAllVegetables();
        }
    }
}
