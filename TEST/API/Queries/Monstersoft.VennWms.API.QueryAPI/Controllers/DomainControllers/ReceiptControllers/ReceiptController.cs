﻿using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReceiptControllers;

public class ReceiptController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] ReceiptsDetailLevel detailLevel)
    {
        GetByCodeReceiptQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeReceiptResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReceiptsDetailLevel detailLevel)
    {
        GetByIdReceiptQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdReceiptResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] ReceiptsDetailLevel detailLevel)
    {
        GetListReceiptQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListReceiptListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReceiptDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReceiptQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReceiptListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
