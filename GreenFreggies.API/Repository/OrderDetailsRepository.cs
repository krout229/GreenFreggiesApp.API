using GreenFreggies.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFreggies.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenFreggies.API.Repository
{
    public class OrderDetailsRepository : IOrderDetails
    {
        private VegetablesDbContext _vegetablesDbContext;
        public OrderDetailsRepository(VegetablesDbContext vegetablesDbContext)
        {
            _vegetablesDbContext = vegetablesDbContext;
        }
        public string DeleteOrderDetails(int OrderId)
        {
            string msg = "";
            OrderDetails deleteOrder = _vegetablesDbContext.orderDetails.Find(OrderId);//storing the details of the vegetable in the obj 
            if (deleteOrder != null)
            {
                _vegetablesDbContext.orderDetails.Remove(deleteOrder);
                _vegetablesDbContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<OrderDetails> GetAllOrderDetails()
        {
            List<OrderDetails> order = _vegetablesDbContext.orderDetails.ToList();
            return order; 
        }

        public OrderDetails GetOrderDetails(int OrderId)
        {
            OrderDetails order = _vegetablesDbContext.orderDetails.Find(OrderId);
            return order; 
        }


        public string SaveOrderDetails(OrderDetails orderDetails)
        {
            _vegetablesDbContext.orderDetails.Add(orderDetails);
            _vegetablesDbContext.SaveChanges();
            return "Saved";
        }

      
        public string UpdateOrderDetails(OrderDetails orderDetails)
        {
            _vegetablesDbContext.Entry(orderDetails).State = EntityState.Modified;
            _vegetablesDbContext.SaveChanges();
            return "Updated";
        }

        
    }
}
