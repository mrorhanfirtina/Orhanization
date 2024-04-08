using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class SupplierController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeSupplierQuery query = new() { Code = code };

        GetByCodeSupplierResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdSupplierQuery query = new() { Id = id };

        GetByIdSupplierResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSupplierQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListSupplierListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicSupplierQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicSupplierListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
