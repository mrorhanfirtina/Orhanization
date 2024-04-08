using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.CommonControllers;

public class ContainerUnitController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeContainerUnitQuery query = new() { Code = code };

        GetByCodeContainerUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdContainerUnitQuery query = new() { Id = id };

        GetByIdContainerUnitResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListContainerUnitQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListContainerUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicContainerUnitQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicContainerUnitListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
