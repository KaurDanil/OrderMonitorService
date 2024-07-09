using OrderMonitorService.Models;
using OrderMonitorService.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderMonitorService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return _orderRepository.GetAllOrdersAsync();
        }

        public Task<Order> GetOrderByIdAsync(int id)
        {
            return _orderRepository.GetOrderByIdAsync(id);
        }

        public Task AddOrderAsync(Order order)
        {
            return _orderRepository.AddOrderAsync(order);
        }

        public Task UpdateOrderAsync(Order order)
        {
            return _orderRepository.UpdateOrderAsync(order);
        }

        public Task DeleteOrderAsync(int id)
        {
            return _orderRepository.DeleteOrderAsync(id);
        }
    }
}