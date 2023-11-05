using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Products;

namespace MyStore.Domain.Entities.ProductsImages;

[Table("product_images", Schema = "public")]
public class ProductImages
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey("product_id")]
    public virtual Product? Product { get; set; }

    [MaxLength(255)]
    [Column("image")]
    public required string Image { get; set; }
}