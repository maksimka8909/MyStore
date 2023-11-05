using MyStore.Data.Repositories;
using MyStore.Domain.Entities.Products;
using MyStore.Domain.Interfaces;
using MyStore.Domain.UseCases;
using MyStore.Services;

namespace MyStore.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddMyServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IRepository<Product>, ProductRepository>();
        serviceCollection.AddTransient<IUserRepository, UserRepository>();
        serviceCollection.AddTransient<ICommonRepository, CommonRepository>();

        serviceCollection.AddTransient<ProductService>();
        serviceCollection.AddTransient<UserService>();
        
        serviceCollection.AddTransient<ProductUseCase>();
        serviceCollection.AddTransient<UserUseCase>();
        
        return serviceCollection;
    }
}