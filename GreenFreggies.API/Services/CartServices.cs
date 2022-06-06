using GreenFreggies.API.Models;
using GreenFreggies.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Services
{
    public class CartServices
    {
        private ICartRepository _cartRepository;
        public CartServices(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public string SaveCart(cart cart)
        {
            return _cartRepository.SaveCart(cart);
        }
        public string DeleteCart(int CartId)
        {
            return _cartRepository.DeleteCart(CartId);
        }
        public string UpdateCart(cart cart)
        {
            return _cartRepository.UpdateCart(cart);
        }
        public cart GetCart(int CartId)
        {
            return _cartRepository.GetCart(CartId);
        }
        public List<cart> GetAllCart()
        {
            return _cartRepository.GetAllCart();
        }
    }
}