using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Users;

namespace MyStore.Domain.Entities.UserAddress;

[Table("user_addresses", Schema = "public")]
public class UserAddress
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey("user_id")]
    public virtual User? User { get; set; }

    [MaxLength(255)]
    public required string Address { get; set; }

    [MaxLength(50)]
    [Column("city")]
    public required string City { get; set; }

    [MaxLength(255)]
    [Column("comment")]
    public required string Comment { get; set; }
}