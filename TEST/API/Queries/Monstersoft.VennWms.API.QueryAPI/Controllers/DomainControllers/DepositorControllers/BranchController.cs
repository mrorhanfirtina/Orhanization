using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class BranchController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] BranchesDetailLevel detailLevel)
    {
        GetByCodeBranchQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeBranchResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] BranchesDetailLevel detailLevel)
    {
        GetByIdBranchQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdBranchResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] BranchesDetailLevel detailLevel)
    {
        GetListBranchQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListBranchListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] BranchDynamicModel? dynamicModel = null)
    {
        GetListByDynamicBranchQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel .DetailLevel};
        GetListResponse<GetListByDynamicBranchListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
