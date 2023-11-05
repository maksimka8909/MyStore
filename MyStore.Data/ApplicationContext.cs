using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;
using MyStore.Domain.Entities.Categories;
using MyStore.Domain.Entities.Orders;
using MyStore.Domain.Entities.Products;
using MyStore.Domain.Entities.Users;

namespace MyStore.Data;

public sealed class ApplicationContext : DbContext
{
    public required DbSet<User> Users { get; set; }

    public required DbSet<Product> Products { get; set; }

    public required DbSet<Order> Orders { get; set; }

    public required DbSet<Category> Categories { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}