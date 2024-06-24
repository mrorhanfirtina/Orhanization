using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.BarcodeControllers;

public class BarcodePrinterController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBarcodePrinterCommand createBarcodePrinterCommand)
    {
        CreatedBarcodePrinterResponse response = await Mediator.Send(createBarcodePrinterCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBarcodePrinterCommand updateBarcodePrinterCommand)
    {
        UpdatedBarcodePrinterResponse response = await Mediator.Send(updateBarcodePrinterCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBarcodePrinterCommand deleteBarcodePrinterCommand)
    {
        DeletedBarcodePrinterResponse response = await Mediator.Send(deleteBarcodePrinterCommand);
        return Ok(response);
    }
}

