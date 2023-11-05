using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.ProductsImages;

namespace MyStore.Domain.Entities.Products;

[Table("products", Schema = "public")]
public class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [MaxLength(255)]
    [Column("name")]
    public required string Name { get; set; }

    [MaxLength(255)]
    [Column("description")]
    public required string Description { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("in_stock")]
    public int InStock { get; set; }

    [Column("status")]
    public bool Status { get; set; }

    public virtual IEnumerable<ProductImages> Images { get; set; } = new List<ProductImages>();

    public virtual IEnumerable<ProductFeature.ProductFeature> Features { get; set; } = new List<ProductFeature.ProductFeature>();

    public Product(string name, string description, decimal price, int inStock)
    {
        Name = name;
        Description = description;
        Price = price;
        InStock = inStock;
        Status = true;
    }
}