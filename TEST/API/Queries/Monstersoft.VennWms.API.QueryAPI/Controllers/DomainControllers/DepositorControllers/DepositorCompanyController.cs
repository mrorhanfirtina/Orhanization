using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeDepositorCompanyQuery query = new() { Code = code };

        GetByCodeDepositorCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdDepositorCompanyQuery query = new() { Id = id };

        GetByIdDepositorCompanyResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicDepositorCompanyQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicDepositorCompanyListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
