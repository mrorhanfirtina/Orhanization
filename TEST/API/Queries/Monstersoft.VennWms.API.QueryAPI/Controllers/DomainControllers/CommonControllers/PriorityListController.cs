using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class PriorityListController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] PriorityListsDetailLevel detailLevel)
    {
        GetByCodePriorityListQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodePriorityListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] PriorityListsDetailLevel detailLevel)
    {
        GetByIdPriorityListQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdPriorityListResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPriorityListQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListPriorityListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] PriorityListDynamicModel? dynamicModel = null)
    {
        GetListByDynamicPriorityListQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicPriorityListListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}






