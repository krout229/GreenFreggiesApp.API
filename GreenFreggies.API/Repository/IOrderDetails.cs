using GreenFreggies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFreggies.API.Repository
{
   public interface IOrderDetails
    {
        public string SaveOrderDetails(OrderDetails orderDetails);
        public string UpdateOrderDetails(OrderDetails orderDetails);
        public string DeleteOrderDetails(int OrderId);
        OrderDetails GetOrderDetails(int OrderId);
        List<OrderDetails> GetAllOrderDetails();
    }
}
