using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ShipmentControllers;

public class ShipmentAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ShipmentAttributesDetailLevel detailLevel)
    {
        GetByCodeShipmentAttributeQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeShipmentAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ShipmentAttributesDetailLevel detailLevel)
    {
        GetByIdShipmentAttributeQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdShipmentAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ShipmentAttributesDetailLevel detailLevel)
    {
        GetListShipmentAttributeQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListShipmentAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ShipmentAttributeDynamicModel? dynamicModel = null)
    {
        GetListByDynamicShipmentAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicShipmentAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
