using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetListByDynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.SerialControllers;

public class SerialController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SerialsDetailLevel detailLevel)
    {
        GetByIdSerialQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSerialResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SerialDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSerialQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSerialListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

