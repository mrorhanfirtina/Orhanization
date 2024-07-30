using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetListByDynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.SerialControllers;

public class ExpectedSerialHierarchyController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ExpectedSerialHierarchiesDetailLevel detailLevel)
    {
        GetByIdExpectedSerialHierarchyQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdExpectedSerialHierarchyResponse result = await Mediator.Send(query);

        return Ok(result);
    }


    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ExpectedSerialHierarchyDynamicModel? dynamicModel = null)
    {
        GetListByDynamicExpectedSerialHierarchyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}

