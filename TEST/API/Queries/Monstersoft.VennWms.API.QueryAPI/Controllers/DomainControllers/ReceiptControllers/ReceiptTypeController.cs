using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ReceiptTypesDetailLevel detailLevel)
    {
        GetByCodeReceiptTypeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeReceiptTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReceiptTypesDetailLevel detailLevel)
    {
        GetByIdReceiptTypeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdReceiptTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ReceiptTypesDetailLevel detailLevel)
    {
        GetListReceiptTypeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListReceiptTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReceiptTypeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReceiptTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReceiptTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
