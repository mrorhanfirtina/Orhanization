using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeOrderAttributeQuery query = new() { Code = code };

        GetByCodeOrderAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdOrderAttributeQuery query = new() { Id = id };

        GetByIdOrderAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOrderAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListOrderAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicOrderAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicOrderAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
