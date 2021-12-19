using ECommerceDemo.Core.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceDemo.Core.Infrastructure
{
    public static class ServiceInitializer
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();
        }
    }
}
