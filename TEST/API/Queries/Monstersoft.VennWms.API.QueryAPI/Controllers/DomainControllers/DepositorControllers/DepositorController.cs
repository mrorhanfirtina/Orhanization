using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class DepositorController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeDepositorQuery query = new() { Code = code };

        GetByCodeDepositorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdDepositorQuery query = new() { Id = id };

        GetByIdDepositorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListDepositorQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListDepositorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicDepositorQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicDepositorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
