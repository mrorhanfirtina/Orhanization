using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class CompanyController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] CompaniesDetailLevel detailLevel)
    {
        GetByCodeCompanyQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] CompaniesDetailLevel detailLevel)
    {
        GetByIdCompanyQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCompanyQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListCompanyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] CompanyDynamicModel? dynamicModel = null)
    {
        GetListByDynamicCompanyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicCompanyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
