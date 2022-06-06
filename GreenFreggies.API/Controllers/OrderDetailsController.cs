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
    public class OrderDetailsController : Controller
    {
        private orderDetailsServices _orderDetailsServices;
        public OrderDetailsController(orderDetailsServices userDetailsServices)
        {
            _orderDetailsServices = userDetailsServices;
        }
        [HttpPost("SaveOrderDetails")]
        public IActionResult SaveOrderDetails(OrderDetails orderDetails)
        {
            return Ok(_orderDetailsServices.SaveOrderDetails(orderDetails));
        }

        [HttpPost("DeleteOrderDetails")]
        public IActionResult DeleteOrderDetails(int OrderId)
        {
            return Ok(_orderDetailsServices.DeleteOrderDetails(OrderId));
        }

        [HttpPost("UpdateOrderDetails")]
        public IActionResult UpdateOrderDetails(OrderDetails orderDetails)
        {
            return Ok(_orderDetailsServices.UpdateOrderDetails(orderDetails));
        }

        [HttpGet("GetOrderDetails")]
        public IActionResult GetOrderDetails(int OrderId)
        {
            return Ok(_orderDetailsServices.GetOrderDetails(OrderId));
        }

        [HttpGet("GetAllOrderDetails()")]
        public List<OrderDetails> GetAllOrderDetails()
        {
            return _orderDetailsServices.GetAllOrderDetails();
        }
    }
}
