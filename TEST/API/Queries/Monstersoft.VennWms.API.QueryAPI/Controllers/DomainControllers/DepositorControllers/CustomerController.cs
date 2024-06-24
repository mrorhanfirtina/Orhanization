using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class CustomerController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] CustomersDetailLevel detailLevel)
    {
        GetByCodeCustomerQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeCustomerResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] CustomersDetailLevel detailLevel)
    {
        GetByIdCustomerQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdCustomerResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] CustomersDetailLevel detailLevel)
    {
        GetListCustomerQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListCustomerListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] CustomerDynamicModel? dynamicModel = null)
    {
        GetListByDynamicCustomerQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicCustomerListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
