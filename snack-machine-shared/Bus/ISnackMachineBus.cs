namespace snack_machine_shared.Bus;

public interface ISnackMachineBus
{
    Task PublishMessage<T>(T message) where T: class, IBusMessage;
}
