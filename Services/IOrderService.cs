using System.Collections.Generic;
using System.Threading.Tasks;
using OrderMonitorService.Models;

namespace OrderMonitorService.Services
{
    public interface IOrderService
    {
    Task<IEnumerable<Order>> GetAllOrdersAsync();
    Task<Order> GetOrderByIdAsync(int id);
    Task AddOrderAsync(Order order);
    Task UpdateOrderAsync(Order order);
    Task DeleteOrderAsync(int id);
    }
}