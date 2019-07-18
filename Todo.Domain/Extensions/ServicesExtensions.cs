using Microsoft.Extensions.DependencyInjection;
using Todo.Domain.Interfaces;
using Todo.Domain.Services;

namespace Todo.Domain.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServicesExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRegisterService, RegisterService>();
            return services;
        }
    }
}