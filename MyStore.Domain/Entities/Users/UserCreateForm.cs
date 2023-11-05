namespace MyStore.Domain.Entities.Users;

public class UserCreateForm
{
    public string Name { get; set; }

    public string Avatar { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public UserCreateForm(string name, string avatar, string email, string lastName, string firstName,
        string middleName, string password)
    {
        Name = name;
        Avatar = avatar;
        Email = email;
        LastName = lastName;
        Password = password;
        FirstName = firstName;
        MiddleName = middleName;
    }
}