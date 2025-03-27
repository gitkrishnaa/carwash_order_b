
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace OrderService.Models
{
    [Index(nameof(OrderId), IsUnique = true)]
    
  public class Order
{
    [Key]
    public int Id { get; set; }

    public string? CustomerId { get; set; }
    public string? SelectedWasherId { get; set; }
    public string? ServiceId { get; set; }
    public string? ServiceName { get; set; }
    public string? ServiceAmount { get; set; }
    public string? ReviewText { get; set; }
    public string? Rating { get; set; }
    public string PaymentId { get; set; } = Guid.NewGuid().ToString(); // ✅ Default value
    public string? WorkStatus { get; set; }
    public bool IsWasherAccepted { get; set; }  // ✅ bool is always required by default
    public string OrderId { get; set; } = Guid.NewGuid().ToString();  // ✅ Auto-generated
}

}
