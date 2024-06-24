using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.BarcodeControllers;

public class BarcodeAreaController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBarcodeAreaCommand createBarcodeAreaCommand)
    {
        CreatedBarcodeAreaResponse response = await Mediator.Send(createBarcodeAreaCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBarcodeAreaCommand updateBarcodeAreaCommand)
    {
        UpdatedBarcodeAreaResponse response = await Mediator.Send(updateBarcodeAreaCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBarcodeAreaCommand deleteBarcodeAreaCommand)
    {
        DeletedBarcodeAreaResponse response = await Mediator.Send(deleteBarcodeAreaCommand);
        return Ok(response);
    }
}

