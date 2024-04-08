﻿using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class BranchController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeBranchQuery query = new() { Code = code };

        GetByCodeBranchResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdBranchQuery query = new() { Id = id };

        GetByIdBranchResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBranchQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListBranchListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicBranchQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicBranchListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
