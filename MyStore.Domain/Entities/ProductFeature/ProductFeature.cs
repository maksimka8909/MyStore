using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Features;
using MyStore.Domain.Entities.Products;

namespace MyStore.Domain.Entities.ProductFeature;

[Table("product_features", Schema = "public")]
public class ProductFeature
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey("product_id")]
    public virtual Product? Product { get; set; }

    [ForeignKey("feature_id")]
    public virtual Feature? Feature { get; set; }

    [Column("value")]
    public int Value { get; set; }
}