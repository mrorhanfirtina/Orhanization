using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeReturnQuery query = new() { Code = code };

        GetByCodeReturnResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReturnQuery query = new() { Id = id };

        GetByIdReturnResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReturnQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReturnListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReturnQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReturnListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
