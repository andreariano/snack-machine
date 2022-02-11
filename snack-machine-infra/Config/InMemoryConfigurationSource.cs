using Microsoft.Extensions.Configuration;

namespace snack_machine_infra.Config;

public class InMemoryConfigurationSource : IConfigurationSource
{
    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new InMemoryConfigurationProvider();
    }
}
