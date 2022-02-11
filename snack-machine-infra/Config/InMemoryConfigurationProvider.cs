using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace snack_machine_infra.Config;

public class InMemoryConfigurationProvider : ConfigurationProvider
{
    public override void Load()
    {
        Data.Add("key", "value");
    }
}
