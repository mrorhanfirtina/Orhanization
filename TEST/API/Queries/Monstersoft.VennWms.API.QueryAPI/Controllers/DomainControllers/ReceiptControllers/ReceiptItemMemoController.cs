using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptItemMemoController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReceiptItemMemoQuery query = new() { Id = id };

        GetByIdReceiptItemMemoResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReceiptItemMemoQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReceiptItemMemoListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
