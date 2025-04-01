using OrderService.Data;
using OrderService.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

// get customer order list
public async Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(string customerId)
{
    return await _context.Orders
                         .Where(o => o.CustomerId == customerId)
                         .ToListAsync();
}

public async Task<IEnumerable<Order>> GetOrdersByWasherIdAsync(string id)
{
    return await _context.Orders
                         .Where(o => o.SelectedWasherId == id)
                         .ToListAsync();
}

  // Get order by OrderId
    public async Task<Order?> GetOrderByOrderIdAsync(string orderId)
    {
        return await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);
    }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
