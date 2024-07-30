using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetListByDynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.SerialControllers;

public class SerialHierarchyController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SerialHierarchiesDetailLevel detailLevel)
    {
        GetByIdSerialHierarchyQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSerialHierarchyResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SerialHierarchyDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSerialHierarchyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSerialHierarchyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

