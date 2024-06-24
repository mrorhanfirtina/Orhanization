using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.BarcodeControllers;

public class BarcodePrinterController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] BarcodePrintersDetailLevel detailLevel)
    {
        GetByIdBarcodePrinterQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdBarcodePrinterResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] BarcodePrinterDynamicModel? dynamicModel = null)
    {
        GetListByDynamicBarcodePrinterQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel , DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicBarcodePrinterListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
