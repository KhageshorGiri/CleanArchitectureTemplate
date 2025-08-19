using Microsoft.Extensions.DependencyInjection;

namespace TricketManagement.Infrastructure.LoggingProvider;

public static class LoggingServiceExtension
{
    public static IServiceCollection RegisterSerilogConfiguration(this IServiceCollection services)
    {
        return services;
    }
}
