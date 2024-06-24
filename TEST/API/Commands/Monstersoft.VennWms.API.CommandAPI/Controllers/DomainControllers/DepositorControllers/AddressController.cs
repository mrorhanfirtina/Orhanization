using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class AddressController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAddressCommand createAddressCommand)
    {
        CreatedAddressResponse response = await Mediator.Send(createAddressCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAddressCommand updateAddressCommand)
    {
        UpdatedAddressResponse response = await Mediator.Send(updateAddressCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAddressCommand deleteAddressCommand)
    {
        DeletedAddressResponse response = await Mediator.Send(deleteAddressCommand);
        return Ok(response);
    }
}

