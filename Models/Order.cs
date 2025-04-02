using System;
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
        public string? washerName { get; set; }
        public string? ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceAmount { get; set; }
        public string? ReviewText { get; set; }
        public string? Rating { get; set; }
        public bool? IsPayment { get; set; } = false;
        public string? paymentStatus { get; set; } = "pending";
        public string? PaymentId { get; set; }
        public string? WorkStatus { get; set; } = "pending"; // completed - when work is accepted, ongoing -
        public bool IsWasherAccepted { get; set; } = false;
        public string OrderId { get; set; } = Guid.NewGuid().ToString();

        // ✅ Automatically set when inserting a new record
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // ✅ Updated whenever the record is modified
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
