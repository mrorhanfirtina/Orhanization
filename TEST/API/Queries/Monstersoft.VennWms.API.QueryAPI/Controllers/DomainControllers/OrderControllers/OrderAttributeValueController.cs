using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.OrderControllers;

public class OrderAttributeValueController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderAttributeValuesDetailLevel detailLevel)
    {
        GetByIdOrderAttributeValueQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderAttributeValueResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderAttributeValueDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderAttributeValueQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderAttributeValueListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
