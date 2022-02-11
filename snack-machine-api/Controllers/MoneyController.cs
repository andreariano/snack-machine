using Microsoft.AspNetCore.Mvc;
using MediatR;
using snack_machine_api.Application.Commands;

namespace snack_machine_api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class MoneyController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IConfiguration _configuration;

    public MoneyController(IMediator mediator, IConfiguration configuration)
    {
        _mediator = mediator;
        _configuration = configuration;
    }



    [HttpPost]
    [Route("")]
    public void InsertMoney([FromBody] InsertMoneyCommand command)
    {
        _mediator.Send(command);
    }
}
