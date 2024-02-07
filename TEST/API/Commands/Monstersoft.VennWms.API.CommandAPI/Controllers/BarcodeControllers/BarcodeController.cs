using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.BarcodeControllers;

public class BarcodeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBarcodeCommand createBarcodeCommand)
    {
        CreatedBarcodeResponse response = await Mediator.Send(createBarcodeCommand);
        return Ok (response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBarcodeCommand updateBarcodeCommand)
    {
        return Ok(await Mediator.Send(updateBarcodeCommand));
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBarcodeCommand deleteBarcodeCommand)
    {
        return Ok(await Mediator.Send(deleteBarcodeCommand));
    }

}
