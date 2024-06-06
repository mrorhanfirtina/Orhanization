using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetList;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.BarcodeControllers;


[Route("api/[controller]")]
[ApiController]
public class BarcodeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBarcodeCommand createBarcodeCommand)
    {
        CreatedBarcodeResponse response = await Mediator.Send(createBarcodeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBarcodeCommand updateBarcodeCommand)
    {
        UpdatedBarcodeResponse response = await Mediator.Send(updateBarcodeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBarcodeCommand deleteBarcodeCommand)
    {
        DeletedBarcodeResponse response = await Mediator.Send(deleteBarcodeCommand);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] BarcodesDetailLevel detailLevel)
    {
        GetListBarcodeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListBarcodeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

