using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentAttributeValueController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdShipmentAttributeValueQuery query = new() { Id = id };

        GetByIdShipmentAttributeValueResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicShipmentAttributeValueQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
