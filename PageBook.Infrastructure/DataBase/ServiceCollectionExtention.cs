using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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


        // services.AddScoped<IUnitOfWork, UnitOfWork>();
        // services.AddScoped<IUserRepository, UserRepository>();
        // services.AddScoped<IPostRepository, PostRepository>();
        // services.AddScoped<ICommentRepository, CommentRepository>();
    }
}
