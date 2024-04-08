using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeReceiptAttributeQuery query = new() { Code = code };

        GetByCodeReceiptAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReceiptAttributeQuery query = new() { Id = id };

        GetByIdReceiptAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReceiptAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReceiptAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReceiptAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReceiptAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
