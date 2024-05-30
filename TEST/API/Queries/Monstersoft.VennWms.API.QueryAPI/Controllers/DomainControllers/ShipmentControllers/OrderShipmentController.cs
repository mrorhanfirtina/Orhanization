using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class OrderShipmentController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] OrderShipmentsDetailLevel detailLevel)
    {
        GetByCodeOrderShipmentQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeOrderShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] OrderShipmentsDetailLevel detailLevel)
    {
        GetByIdOrderShipmentQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdOrderShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] OrderShipmentsDetailLevel detailLevel)
    {
        GetListOrderShipmentQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListOrderShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] OrderShipmentDynamicModel? dynamicModel = null)
    {
        GetListByDynamicOrderShipmentQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicOrderShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
