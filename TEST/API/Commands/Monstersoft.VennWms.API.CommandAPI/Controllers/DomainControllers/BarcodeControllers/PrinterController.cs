using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.BarcodeControllers;

public class PrinterController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePrinterCommand createPrinterCommand)
    {
        CreatedPrinterResponse response = await Mediator.Send(createPrinterCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePrinterCommand updatePrinterCommand)
    {
        UpdatedPrinterResponse response = await Mediator.Send(updatePrinterCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePrinterCommand deletePrinterCommand)
    {
        DeletedPrinterResponse response = await Mediator.Send(deletePrinterCommand);
        return Ok(response);
    }
}

