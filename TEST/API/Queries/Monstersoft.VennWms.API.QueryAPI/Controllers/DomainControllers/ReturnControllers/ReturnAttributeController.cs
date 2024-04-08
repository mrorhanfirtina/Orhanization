using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeReturnAttributeQuery query = new() { Code = code };

        GetByCodeReturnAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReturnAttributeQuery query = new() { Id = id };

        GetByIdReturnAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReturnAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReturnAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReturnAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReturnAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
