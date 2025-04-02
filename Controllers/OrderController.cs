using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
namespace OrderService.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            return Ok(await _orderRepository.GetAllOrdersAsync());
        }

        [HttpGet("customer/list/{customerId}")]
public async Task<ActionResult<IEnumerable<Order>>> CustomerOrderlist(string customerId)
{
    var customerOrders = await _orderRepository.GetOrdersByCustomerIdAsync(customerId);
    if (customerOrders == null || !customerOrders.Any())
    {
        return NotFound(new { message = "No orders found for this customer." });
    }
    return Ok(customerOrders);
}
 [HttpGet("washer/list/{id}")]
public async Task<ActionResult<IEnumerable<Order>>> WasherOrderlist(string id)
{
    var Orderslist = await _orderRepository.GetOrdersByWasherIdAsync(id);
    if (Orderslist == null || !Orderslist.Any())
    {
        return NotFound(new { message = "No orders found for this washer." });
    }
    return Ok(Orderslist);
}


        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
            // return Ok(new {status="ok"});
        }



         [HttpGet("orderId/{id}")]
        public async Task<ActionResult<Order>> GetOrderByOrderIdAsync(string id)
        {
            var order = await _orderRepository.GetOrderByOrderIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
            // return Ok(new {status="ok"});
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateOrder(Order order)
        {
           
             string data = JsonSerializer.Serialize(order);
              Console.WriteLine(data);
            await _orderRepository.AddOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
            // return Ok(new {msg="ok"});
        }

        [HttpPost("update2/{id}")]
        public async Task<ActionResult> UpdateOrder(int id, Order order)
        {
             Console.WriteLine("id");
            Console.WriteLine(id);
             Console.WriteLine(JsonSerializer.Serialize(order));
            if (id != order.Id)
            {
                return BadRequest();
            }
            await _orderRepository.UpdateOrderAsync(order);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            await _orderRepository.DeleteOrderAsync(id);
            return NoContent();
        }
    }


    
}
