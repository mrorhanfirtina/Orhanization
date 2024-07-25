using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class SiteController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] SitesDetailLevel detailLevel)
    {
        GetByCodeSiteQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeSiteResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] SitesDetailLevel detailLevel)
    {
        GetByIdSiteQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdSiteResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSiteQuery query = new() { PageRequest = pageRequest};
        GetListResponse<GetListSiteListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] SiteDynamicModel? dynamicModel = null)
    {
        GetListByDynamicSiteQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicSiteListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
