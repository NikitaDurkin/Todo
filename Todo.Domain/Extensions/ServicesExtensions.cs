using Microsoft.Extensions.DependencyInjection;
using Todo.Domain.Interfaces;
using Todo.Domain.Services;

namespace Todo.Domain.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRegisterService, RegisterService>();
            return services;
        }
    }
}