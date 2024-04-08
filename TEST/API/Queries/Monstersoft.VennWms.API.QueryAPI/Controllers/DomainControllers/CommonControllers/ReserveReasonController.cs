using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ReserveReasonController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeReserveReasonQuery query = new() { Code = code };

        GetByCodeReserveReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdReserveReasonQuery query = new() { Id = id };

        GetByIdReserveReasonResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListReserveReasonQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListReserveReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicReserveReasonQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicReserveReasonListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
