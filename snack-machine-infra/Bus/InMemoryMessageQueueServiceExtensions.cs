using Microsoft.Extensions.DependencyInjection;
using MassTransit;

namespace snack_machine_infra.Bus;

public static class InMemoryMessageQueueServiceExtensions
{
    public static IServiceCollection AddInMemoryMessageQueue(this IServiceCollection services)
    {
        services.AddMassTransit(x =>
        {
            x.UsingInMemory((context, cfg) =>
            {
                cfg.TransportConcurrencyLimit = 100;
                cfg.ConfigureEndpoints(context);
            });
        });
        
        services.AddMassTransitHostedService();

        return services;
    }
}
