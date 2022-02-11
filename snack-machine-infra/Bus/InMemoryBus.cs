using snack_machine_shared.Bus;
using MassTransit;


namespace snack_machine_infra.Bus;
public class InMemoryBus : ISnackMachineBus
{
    readonly IPublishEndpoint _publishEndpoint;

    public InMemoryBus(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    public Task PublishMessage<T>(T message) where T : class, IBusMessage
    {
        return _publishEndpoint.Publish<T>(new
        {
            Value = message
        });
    }
}
