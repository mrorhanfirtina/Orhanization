using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.BarcodeControllers;

public class PrinterController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodePrinterQuery query = new() { Code = code };

        GetByCodePrinterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdPrinterQuery query = new() { Id = id };

        GetByIdPrinterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPrinterQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPrinterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicPrinterQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPrinterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
