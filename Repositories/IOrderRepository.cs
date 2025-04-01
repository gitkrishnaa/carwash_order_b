using OrderService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(int id);
        Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(string customerId);
        Task<IEnumerable<Order>> GetOrdersByWasherIdAsync(string customerId);
        Task<Order?> GetOrderByOrderIdAsync(string orderId);
     
       
        

    }
}
