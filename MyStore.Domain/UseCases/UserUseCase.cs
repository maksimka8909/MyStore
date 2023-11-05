using MyStore.Domain.Entities.Users;
using MyStore.Domain.Interfaces;

namespace MyStore.Domain.UseCases;

public class UserUseCase
{
    private readonly IUserRepository _userRepository;
    private readonly ICommonRepository _commonRepository;

    public UserUseCase(IUserRepository userRepository, ICommonRepository commonRepository)
    {
        _userRepository = userRepository;
        _commonRepository = commonRepository;
    }

    public async Task<bool> IsExist(string email) => await _userRepository.GetUserByEmail(email);

    public async Task<bool> Create(UserCreateForm userInfo)
    {
        await _userRepository.Create(new User(userInfo));
        
        return await _commonRepository.SaveChanges();
    }
}