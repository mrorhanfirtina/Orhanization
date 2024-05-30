using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.BarcodeControllers;


public class BarcodeAreaController : BaseController
{
    
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] BarcodeAreasDetailLevel detailLevel)
    {
        GetByIdBarcodeAreaQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdBarcodeAreaResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] BarcodeAreaDynamicModel dynamicModel = null)
    {
        GetListByDynamicBarcodeAreaQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicBarcodeAreaListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
