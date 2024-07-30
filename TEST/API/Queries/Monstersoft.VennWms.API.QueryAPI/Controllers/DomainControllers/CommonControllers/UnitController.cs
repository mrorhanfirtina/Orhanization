using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class UnitController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] UnitsDetailLevel detailLevel)
    {
        GetByCodeUnitQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id, [FromBody] UnitsDetailLevel detailLevel)
    {
        GetByIdUnitQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListUnitQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] UnitDynamicModel? dynamicModel = null)
    {
        GetListByDynamicUnitQuery query = new() { PageRequest = pageRequest, DetailLevel = dynamicModel.DetailLevel, DynamicQuery = dynamicModel.DynamicQuery };
        GetListResponse<GetListByDynamicUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
