using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Orders;

namespace MyStore.Domain.Entities.OrderItem;

[Table("order_items", Schema = "public")]
public class OrderItem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey("order_id")]
    public virtual required Order Order { get; set; }

    [MaxLength(255)]
    [Column("product_name")]
    public required string ProductName { get; set; }

    [Column("product_price")]
    public required decimal Price { get; set; }

    [Column("amount")]
    public required int Amount { get; set; }
}