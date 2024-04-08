using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.TaskControllers;

public class TaskListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeTaskListQuery query = new() { Code = code };

        GetByCodeTaskListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdTaskListQuery query = new() { Id = id };

        GetByIdTaskListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTaskListQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListTaskListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicTaskListQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicTaskListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
