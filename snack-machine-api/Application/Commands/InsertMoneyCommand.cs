using System.Runtime.Serialization;
using MediatR;
using snack_machine_shared.Bus;

namespace snack_machine_api.Application.Commands;


public class InsertMoneyCommand : IRequest<bool>, IBusMessage
{
    public int Amount { get; private set; }

    public InsertMoneyCommand()
    {
        
    }

    public InsertMoneyCommand(int amount)
    {
        this.Amount = amount;
    }
}
