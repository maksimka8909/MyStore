using MyStore.Domain.Entities.Users;
using MyStore.Domain.UseCases;
using MyStore.ViewModels;

namespace MyStore.Services;

public class UserService
{
   private readonly UserUseCase _userUseCase;

   public UserService(UserUseCase userUseCase)
   {
      _userUseCase = userUseCase;
   }

   public async Task<bool> Create(UserCreateViewModel userInfo)
   {
      var userCreateForm = new UserCreateForm(userInfo.Name, userInfo.Avatar, userInfo.Email, userInfo.LastName,
         userInfo.FirstName, userInfo.MiddleName, userInfo.Password);
      return await _userUseCase.Create(userCreateForm);
   }

   public async Task<bool> IsExist(string email) => await _userUseCase.IsExist(email);
}