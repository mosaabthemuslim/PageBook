using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PageBook.Application.Posts.Commands.CreatePost;
namespace PageBook.Application.Extentions;

public static class Extentions
{


    public static void AddApplication(this IServiceCollection services)
    {
        var applicationAssembly = typeof(Extentions).Assembly;
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));

        services.AddAutoMapper(applicationAssembly);
        services.AddAutoMapper(typeof(PostMappingProfile).Assembly);



        //services.AddScoped<IUserContext, UserContext>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddHttpContextAccessor();
    }

}
