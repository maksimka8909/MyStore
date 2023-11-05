using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Users;
using MyStore.Domain.Interfaces;

namespace MyStore.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _db;

    public UserRepository(ApplicationContext db)
    {
        _db = db;
    }

    public Task<bool> GetUserByEmail(string email) => _db.Users.AnyAsync(u => u.Email == email);

    public async Task Create(User user) => await _db.Users.AddAsync(user);
}