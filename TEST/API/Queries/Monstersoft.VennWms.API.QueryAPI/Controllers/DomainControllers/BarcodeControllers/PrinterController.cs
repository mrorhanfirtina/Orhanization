using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] PrintersDetailLevel detailLevel)
    {
        GetByCodePrinterQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodePrinterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] PrintersDetailLevel detailLevel)
    {
        GetByIdPrinterQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPrinterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] PrintersDetailLevel detailLevel)
    {
        GetListPrinterQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListPrinterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PrinterDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPrinterQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicPrinterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
