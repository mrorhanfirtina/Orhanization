using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants;
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
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] StorageSystemsDetailLevel detailLevel)
    {
        GetByCodeStorageSystemQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeStorageSystemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] StorageSystemsDetailLevel detailLevel)
    {
        GetByIdStorageSystemQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdStorageSystemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] StorageSystemsDetailLevel detailLevel)
    {
        GetListStorageSystemQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListStorageSystemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] StorageSystemDynamicModel? dynamicModel = null)
    {
        GetListByDynamicStorageSystemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicStorageSystemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
