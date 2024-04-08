using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAttributeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeProductAttributeQuery query = new() { Code = code };

        GetByCodeProductAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdProductAttributeQuery query = new() { Id = id };

        GetByIdProductAttributeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListProductAttributeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListProductAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicProductAttributeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicProductAttributeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
