using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStore.Domain.Entities.Categories;

[Table("categories", Schema = "public")]
public class Category
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [MaxLength(255)]
    [Column("name")]
    public required string Name { get; set; }
}