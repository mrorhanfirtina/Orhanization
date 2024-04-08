using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeSiteQuery query = new() { Code = code };

        GetByCodeSiteResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdSiteQuery query = new() { Id = id };

        GetByIdSiteResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSiteQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListSiteListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicSiteQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicSiteListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
