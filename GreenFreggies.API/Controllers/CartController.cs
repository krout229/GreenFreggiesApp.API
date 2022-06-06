using GreenFreggies.API.Models;
using GreenFreggies.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private CartServices _cartServices;
        public CartController(CartServices cartServices)
        {
            _cartServices = cartServices;
        }
        [HttpPost("SaveCart")]
        public IActionResult SaveCart(cart cart)
        {
            return Ok(_cartServices.SaveCart(cart));
        }

        [HttpDelete("DeleteCart")]
        public IActionResult DeleteCart(int CartId)
        {
            return Ok(_cartServices.DeleteCart(CartId));
        }

        [HttpPost("UpdateCart")]
        public IActionResult UpdateCart(cart cart)
        {
            return Ok(_cartServices.UpdateCart(cart));
        }

        [HttpGet("GetCart")]
        public IActionResult GetCart(int CartId)
        {
            return Ok(_cartServices.GetCart(CartId));
        }

        [HttpGet("GetAllCart")]
        public List<cart> GetAllCart()
        {
            return _cartServices.GetAllCart();
        }
    }
}