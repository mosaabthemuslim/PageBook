using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PageBook.Domain.Repositories;
using PageBook.Infrastructure.Repositories;

namespace PageBook.Infrastructure.DataBase;

public static class ServiceCollectionExtention
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PageBookDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        // Add Identity services and Entity Framework stores.
        services.AddScoped<IPostRepository, PostRepository>();



    }
}
