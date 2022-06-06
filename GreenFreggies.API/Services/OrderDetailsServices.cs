using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFreggies.API.Models;
using GreenFreggies.API.Repository;

namespace GreenFreggies.API.Services
{
    public class orderDetailsServices
    {
        private IOrderDetails _orderDetailsRepository;
        public orderDetailsServices(IOrderDetails orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }
        public string SaveOrderDetails(OrderDetails orderDetails)
        {
            return _orderDetailsRepository.SaveOrderDetails(orderDetails);
        }
        public string DeleteOrderDetails(int orderId)
        {
            return _orderDetailsRepository.DeleteOrderDetails(orderId);
        }
        public string UpdateOrderDetails(OrderDetails orderDetails)
        {
            return _orderDetailsRepository.UpdateOrderDetails(orderDetails);
        }
        public OrderDetails GetOrderDetails(int orderId)
        {
            return _orderDetailsRepository.GetOrderDetails(orderId);
        }
        public List<OrderDetails> GetAllOrderDetails()
        {
            return _orderDetailsRepository.GetAllOrderDetails();
        }
    }
}
