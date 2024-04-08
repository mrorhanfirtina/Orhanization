using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.TaskControllers;

public class TaskCodeFormatController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeTaskCodeFormatQuery query = new() { Code = code };

        GetByCodeTaskCodeFormatResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdTaskCodeFormatQuery query = new() { Id = id };

        GetByIdTaskCodeFormatResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTaskCodeFormatQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListTaskCodeFormatListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicTaskCodeFormatQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicTaskCodeFormatListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
