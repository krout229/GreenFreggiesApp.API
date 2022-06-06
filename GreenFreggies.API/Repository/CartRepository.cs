using GreenFreggies.API.Data;
using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public class CartRepository : ICartRepository
    {
        private VegetablesDbContext _vegetablesDb;
        public CartRepository(VegetablesDbContext vegetablesDb)
        {
            _vegetablesDb = vegetablesDb;
        }
        public string DeleteCart(int CartId)
        {
            string msg = "";
            cart deleteCart = _vegetablesDb.Carts.Find(CartId);//storing the details of the vegetable in the obj 
            if (deleteCart != null)
            {
                _vegetablesDb.Carts.Remove(deleteCart);
                _vegetablesDb.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<cart> GetAllCart()
        {
            List<cart> carts = _vegetablesDb.Carts.ToList();
            return carts;
        }

        public cart GetCart(int CartId)
        {
            cart carts = _vegetablesDb.Carts.Find(CartId);
            return carts;
        }

        public string SaveCart(cart cart)
        {
            _vegetablesDb.Carts.Add(cart);
            _vegetablesDb.SaveChanges();
            return "Saved"; ;
        }

        public string UpdateCart(cart cart)
        {
            _vegetablesDb.Entry(cart).State = EntityState.Modified;
            _vegetablesDb.SaveChanges();
            return "Updated";
        }
    }
}
    