using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class SupplierController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSupplierCommand createSupplierCommand)
    {
        CreatedSupplierResponse response = await Mediator.Send(createSupplierCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSupplierCommand updateSupplierCommand)
    {
        UpdatedSupplierResponse response = await Mediator.Send(updateSupplierCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSupplierCommand deleteSupplierCommand)
    {
        DeletedSupplierResponse response = await Mediator.Send(deleteSupplierCommand);
        return Ok(response);
    }
}

