using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeShipmentTypeQuery query = new() { Code = code };

        GetByCodeShipmentTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdShipmentTypeQuery query = new() { Id = id };

        GetByIdShipmentTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListShipmentTypeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListShipmentTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicShipmentTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicShipmentTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
