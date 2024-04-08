using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class UnitController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeUnitQuery query = new() { Code = code };

        GetByCodeUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdUnitQuery query = new() { Id = id };

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
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicUnitQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
