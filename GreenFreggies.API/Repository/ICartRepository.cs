using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
    public interface ICartRepository
    {
        public string SaveCart(cart cart);
        public string UpdateCart(cart cart);
        public string DeleteCart(int CartId);
        cart GetCart(int CartId);
        List<cart> GetAllCart();
    }
}