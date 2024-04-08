using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeShipmentQuery query = new() { Code = code };

        GetByCodeShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdShipmentQuery query = new() { Id = id };

        GetByIdShipmentResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListShipmentQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicShipmentQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicShipmentListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
