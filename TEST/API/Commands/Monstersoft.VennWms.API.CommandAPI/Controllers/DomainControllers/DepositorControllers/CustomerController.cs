using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class CustomerController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCustomerCommand createCustomerCommand)
    {
        CreatedCustomerResponse response = await Mediator.Send(createCustomerCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCustomerCommand updateCustomerCommand)
    {
        UpdatedCustomerResponse response = await Mediator.Send(updateCustomerCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCustomerCommand deleteCustomerCommand)
    {
        DeletedCustomerResponse response = await Mediator.Send(deleteCustomerCommand);
        return Ok(response);
    }
}

