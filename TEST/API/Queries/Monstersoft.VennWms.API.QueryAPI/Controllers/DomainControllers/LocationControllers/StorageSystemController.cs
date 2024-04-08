using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.LocationControllers;

public class StorageSystemController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeStorageSystemQuery query = new() { Code = code };

        GetByCodeStorageSystemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        GetByIdStorageSystemQuery query = new() { Id = id };

        GetByIdStorageSystemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListStorageSystemQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListStorageSystemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicStorageSystemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicStorageSystemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
