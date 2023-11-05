using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Users;

namespace MyStore.Domain.Interfaces;

public interface IUserRepository
{
    public Task<bool> GetUserByEmail(string email);

    public Task Create(User user);

}