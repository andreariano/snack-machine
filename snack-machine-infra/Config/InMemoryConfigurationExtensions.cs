using Microsoft.Extensions.Configuration;

namespace snack_machine_infra.Config;

public static class InMemoryConfigurationExtensions
{
    public static IConfigurationBuilder AddInMemoryConfigurationProvider(this IConfigurationBuilder configuration)
    {
        configuration.Add(new InMemoryConfigurationSource());
        return configuration;
    }
}
