using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class UnitConversionController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] UnitConversionsDetailLevel detailLevel)
    {
        GetByIdUnitConversionQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdUnitConversionResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] UnitConversionDynamicModel? dynamicModel = null)
    {
        GetListByDynamicUnitConversionQuery query = new() { PageRequest = pageRequest,DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicUnitConversionListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

