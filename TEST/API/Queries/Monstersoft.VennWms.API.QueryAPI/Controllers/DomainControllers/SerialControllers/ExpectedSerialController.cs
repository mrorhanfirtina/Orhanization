using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetListByDynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.SerialControllers;

public class ExpectedSerialController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ExpectedSerialsDetailLevel detailLevel)
    {
        GetByIdExpectedSerialQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdExpectedSerialResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ExpectedSerialDynamicModel? dynamicModel = null)
    {
        GetListByDynamicExpectedSerialQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicExpectedSerialListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

