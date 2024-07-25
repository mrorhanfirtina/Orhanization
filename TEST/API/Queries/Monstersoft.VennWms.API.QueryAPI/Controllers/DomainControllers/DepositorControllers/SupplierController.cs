using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] SuppliersDetailLevel detailLevel)
    {
        GetByCodeSupplierQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeSupplierResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SuppliersDetailLevel detailLevel)
    {
        GetByIdSupplierQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSupplierResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSupplierQuery query = new() { PageRequest = pageRequest};
        GetListResponse<GetListSupplierListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SupplierDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSupplierQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSupplierListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
