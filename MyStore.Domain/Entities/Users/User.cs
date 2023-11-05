using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyStore.Domain.Entities.Roles;

namespace MyStore.Domain.Entities.Users;

[Table("users", Schema = "public")]
public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [MaxLength(255)]
    [Column("name")]
    public string Name { get; set; }

    [MaxLength(255)]
    [Column("avatar")]
    public string Avatar { get; set; }

    [MaxLength(255)]
    [Column("email")]
    public string Email { get; set; }

    [MaxLength(255)]
    [Column("email")]
    public string Password { get; set; }

    [Column("role")]
    public Role Role { get; set; }

    [MaxLength(50)]
    [Column("last_name")]
    public string LastName { get; set; }

    [MaxLength(50)]
    [Column("first_name")]
    public string FirstName { get; set; }

    [MaxLength(50)]
    [Column("middle_name")]
    public string MiddleName { get; set; }

    public User(UserCreateForm _user)
    {
        Name = _user.Name;
        LastName = _user.LastName;
        MiddleName = _user.MiddleName;
        FirstName = _user.FirstName;
        Avatar = _user.Avatar;
        Email = _user.Email;
        Password = _user.Password;
        Role = Role.Customer;
    }

    public virtual IEnumerable<UserAddress.UserAddress> Addresses { get; set; } = new List<UserAddress.UserAddress>();
}