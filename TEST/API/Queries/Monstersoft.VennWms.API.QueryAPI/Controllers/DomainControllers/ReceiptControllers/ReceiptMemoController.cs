using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptMemoController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReceiptMemosDetailLevel detailLevel)
    {
        GetByIdReceiptMemoQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdReceiptMemoResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReceiptMemoDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReceiptMemoQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReceiptMemoListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
