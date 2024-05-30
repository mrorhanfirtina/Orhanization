using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.WorkTaskDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.TaskControllers;

public class TaskListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] TaskListsDetailLevel detailLevel)
    {
        GetByCodeTaskListQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeTaskListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] TaskListsDetailLevel detailLevel)
    {
        GetByIdTaskListQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdTaskListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] TaskListsDetailLevel detailLevel)
    {
        GetListTaskListQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListTaskListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] TaskListDynamicModel? dynamicModel = null)
    {
        GetListByDynamicTaskListQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicTaskListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
