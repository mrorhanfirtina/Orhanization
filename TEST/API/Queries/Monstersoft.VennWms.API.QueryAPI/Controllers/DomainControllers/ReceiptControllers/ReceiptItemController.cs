using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptItemController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReceiptItemQuery query = new() { Id = id };

        GetByIdReceiptItemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReceiptItemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReceiptItemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
