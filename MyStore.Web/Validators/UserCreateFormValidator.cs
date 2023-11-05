using FluentValidation;
using MyStore.Domain.Entities.Users;
using MyStore.Services;

namespace MyStore.Validators;

public class UserCreateFormValidator : AbstractValidator<UserCreateForm>
{
    private readonly UserService _userService;

    public UserCreateFormValidator(UserService userService)
    {
        _userService = userService;
        RuleFor(u => u.Email).NotNull().WithMessage("Поле почты не заполнено")
            .NotEmpty().WithMessage("Поле почты не заполнено")
            .MustAsync(IsEmailExist).WithMessage("Такой пользователь существует");
    }

    private async Task<bool> IsEmailExist(string email, CancellationToken _cancellation) =>
        !await _userService.IsExist(email);
}