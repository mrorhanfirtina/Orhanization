using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class DepositorCompanyController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] DepositorCompaniesDetailLevel detailLevel)
    {
        GetByCodeDepositorCompanyQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeDepositorCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] DepositorCompaniesDetailLevel detailLevel)
    {
        GetByIdDepositorCompanyQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdDepositorCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DepositorCompanyDynamicModel? dynamicModel = null)
    {
        GetListByDynamicDepositorCompanyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicDepositorCompanyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
