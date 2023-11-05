namespace MyStore.ViewModels;

public class UserCreateViewModel
{
    public required string Name { get; set; }

    public required string Avatar { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public required string LastName { get; set; }

    public required string FirstName { get; set; }

    public required string MiddleName { get; set; }
}