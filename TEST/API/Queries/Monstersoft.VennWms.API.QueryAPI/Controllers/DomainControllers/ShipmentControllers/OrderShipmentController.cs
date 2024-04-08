using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeOrderShipmentQuery query = new() { Code = code };

        GetByCodeOrderShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdOrderShipmentQuery query = new() { Id = id };

        GetByIdOrderShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOrderShipmentQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListOrderShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicOrderShipmentQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicOrderShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
