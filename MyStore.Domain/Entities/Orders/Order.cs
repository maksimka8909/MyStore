using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Users;

namespace MyStore.Domain.Entities.Orders;

[Table("orders")]
public class Order
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public virtual IEnumerable<OrderItem.OrderItem> OrderItems { get; set; } = new List<OrderItem.OrderItem>();

    [ForeignKey("user_id")]
    public virtual User? User { get; set; }

    [MaxLength(50)]
    [Column("city")]
    public required string City { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [MaxLength(255)]
    [Column("address")]
    public required string Address { get; set; }

    [Column("comment")]
    public required string Comment { get; set; }
}