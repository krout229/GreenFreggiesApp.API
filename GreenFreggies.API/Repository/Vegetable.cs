using GreenFreggies.API.Data;
using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public class Vegetable : IVegetable
    {
        private VegetablesDbContext _vegetablesDb;
        public Vegetable(VegetablesDbContext vegetablesDb)
        {
            _vegetablesDb = vegetablesDb;
        }
        public string DeleteVegetable(int VegetableID)
        {
            string msg = "";
            vegetableDetails deleteVeggie = _vegetablesDb.VegetableDetails.Find(VegetableID);//storing the details of the vegetable in the obj 
            if (deleteVeggie != null)
            {
                _vegetablesDb.VegetableDetails.Remove(deleteVeggie);
               _vegetablesDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<vegetableDetails> GetAllVegetables()
        {
            List<vegetableDetails> Veggies = _vegetablesDb.VegetableDetails.ToList();
            return Veggies;
        }

        public vegetableDetails GetVegetable(int VegetableID)
        {
           vegetableDetails Veggie = _vegetablesDb.VegetableDetails.Find(VegetableID);
            return Veggie;
        }

        public string SaveVegetable(vegetableDetails vegetable)
        {
            _vegetablesDb.VegetableDetails.Add(vegetable);
            
            _vegetablesDb.SaveChanges();
            return "Saved"; 
        }

        public string UpdateVegetable(vegetableDetails vegetable)
        {
            _vegetablesDb.Entry(vegetable).State = EntityState.Modified;
            _vegetablesDb.SaveChanges();
            return "Updated";
        }
    }
}
