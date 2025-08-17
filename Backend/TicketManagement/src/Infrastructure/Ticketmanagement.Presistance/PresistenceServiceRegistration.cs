using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ticketmanagement.Presistance.Repositories;
using TicketManagement.Application.Contracts.Prestience;

namespace Ticketmanagement.Presistance;

public static class PresistenceServiceRegistration
{
    public static IServiceCollection AddPresistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TicketmanagemetnDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultSqlServerConnectionString")));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IEventRespository, EventRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    } 
}
