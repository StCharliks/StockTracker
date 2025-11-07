using DolbojebInvest.Application.Dividends;
using DolbojebInvest.Domain.Base;
using DolbojebInvest.Domain.Dividends.Interfaces;
using DolbojebInvest.Infrastructure.DataAccess;
using DolbojebInvest.Infrastructure.IdGeneration;

namespace DolbojebInvest.API.ServiceCollection
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Register infrastructure services here
            services.AddScoped<IDividendRepository, DividendFileRepository>();
            services.AddScoped<IDividendService, DividendService>();
            
            services.AddSingleton<IIdGenerator<long>, SnowflakeIdGenerator>();
            return services;
        }
    }
}
