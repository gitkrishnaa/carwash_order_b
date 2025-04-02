using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging; // Add logging.
using System.Text.Json;
namespace OrderService.Controllers
{
    [Route("api/update")] // Corrected route
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ServiceController> _logger; // Add logger.

        public ServiceController(ApplicationDbContext context, ILogger<ServiceController> logger) // Add logger to constructor.
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("review/{order_id}")]
        public async Task<IActionResult> PatchService(int order_id, [FromBody] Order data)
        {
            string jsonData = JsonSerializer.Serialize(data);
                Console.WriteLine($"Received JSON Data: {jsonData}");

       var service = await _context.Orders.FindAsync(order_id);
       if (service == null) return NotFound("Service not found!");
       service.ReviewText=data.ReviewText;
       service.Rating=data.Rating;
       Console.WriteLine($"Received db Data: {JsonSerializer.Serialize(service)}");
       await _context.SaveChangesAsync();
      return Ok(new { message = "Service updated successfully!" });
            // return Ok("ok");
        }



        [HttpPost("payment/{order_id}")]
        public async Task<IActionResult> UpdatePayment(int order_id, [FromBody] Order data)
        {
            string jsonData = JsonSerializer.Serialize(data);
                Console.WriteLine($"Received JSON Data: {jsonData}");

       var service = await _context.Orders.FindAsync(order_id);
       if (service == null) return NotFound("Service not found!");

      if(data.IsPayment==true){
       service.paymentStatus="completed";
       service.IsPayment=true;
       service.PaymentId=data.PaymentId;
      }
      else{
       service.paymentStatus="failed";
       service.IsPayment=false;
      }

      
       Console.WriteLine($"Received db Data: {JsonSerializer.Serialize(service)}");
       await _context.SaveChangesAsync();
      return Ok(new { message = "Service updated successfully!" });
            // return Ok("ok");
        }

         [HttpPost("workStatus/{order_id}")]
        public async Task<IActionResult> UpdateWorkStatus(int order_id, [FromBody] Order data)
        {
            string jsonData = JsonSerializer.Serialize(data);
                Console.WriteLine($"Received JSON Data: {jsonData}");

       var service = await _context.Orders.FindAsync(order_id);
       if (service == null) return NotFound("Service not found!");

      if(data.IsWasherAccepted==true){
       service.WorkStatus="completed";
       service.IsWasherAccepted=true;
      }
      else{
        service.WorkStatus="Declined";
       service.IsWasherAccepted=false;
      }

      
       Console.WriteLine($"Received db Data: {JsonSerializer.Serialize(service)}");
       await _context.SaveChangesAsync();
      return Ok(new { message = "Service updated successfully!" });
            // return Ok("ok");
        }

    }
}



// public async Task<IActionResult> UpdateService(int id, [FromBody] Service updatedService)
//         {
//             var service = await _context.Services.FindAsync(id);
//             if (service == null) return NotFound("Service not found!");

//             service.Name = updatedService.Name;
//             service.Description = updatedService.Description;
//             service.Price = updatedService.Price;
//             service.IsActive = updatedService.IsActive;

//             await _context.SaveChangesAsync();
//             return Ok(new { message = "Service updated successfully!" });