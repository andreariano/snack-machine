using snack_machine_infra;
using MediatR;
using snack_machine_shared.Bus;

namespace snack_machine_api.Application.Commands;

public class InsertMoneyCommandHandler : IRequestHandler<InsertMoneyCommand, bool>
{
    private readonly ISnackMachineBus _bus;

    public InsertMoneyCommandHandler(ISnackMachineBus bus)
    {
        _bus = bus;
    }

    public Task<bool> Handle(InsertMoneyCommand request, CancellationToken cancellationToken)
    {
        _bus.PublishMessage<InsertMoneyCommand>(request);

        return Task.FromResult(true);
    }
}
