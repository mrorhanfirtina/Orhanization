using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.WorkTaskDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.TaskControllers;

public class WorkTaskController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] WorkTasksDetailLevel detailLevel)
    {
        GetByCodeWorkTaskQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeWorkTaskResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] WorkTasksDetailLevel detailLevel)
    {
        GetByIdWorkTaskQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdWorkTaskResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListWorkTaskQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListWorkTaskListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] WorkTaskDynamicModel? dynamicModel = null)
    {
        GetListByDynamicWorkTaskQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicWorkTaskListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
