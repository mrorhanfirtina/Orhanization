using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class SiteDepositorController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SiteDepositorsDetailLevel detailLevel)
    {
        GetByIdSiteDepositorQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSiteDepositorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SiteDepositorDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSiteDepositorQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSiteDepositorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
