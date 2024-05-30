using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipItemController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderShipItemsDetailLevel detailLevel)
    {
        GetByIdOrderShipItemQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderShipItemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderShipItemDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderShipItemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderShipItemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
