using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ReturnsDetailLevel detailLevel)
    {
        GetByCodeReturnQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeReturnResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReturnsDetailLevel detailLevel)
    {
        GetByIdReturnQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdReturnResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReturnQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReturnListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReturnDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReturnQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReturnListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
