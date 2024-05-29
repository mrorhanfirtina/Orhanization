using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetList;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class PriorityListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodePriorityListQuery query = new() { Code = code };

        GetByCodePriorityListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdPriorityListQuery query = new() { Id = id };

        GetByIdPriorityListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPriorityListQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPriorityListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicPriorityListQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicPriorityListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






