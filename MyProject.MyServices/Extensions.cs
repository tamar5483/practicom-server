using Microsoft.Extensions.DependencyInjection;
using MyProject.MyServices.Interfaces;
using MyProject.MyServices.Services;
using MyProject.Repositories;
namespace MyProject.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();
            return services;
        }
    }
}



