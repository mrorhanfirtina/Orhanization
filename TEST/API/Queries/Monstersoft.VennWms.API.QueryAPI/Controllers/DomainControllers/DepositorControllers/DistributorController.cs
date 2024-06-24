using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByDynamic;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetList;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.DepositorControllers;

public class DistributorController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code, [FromBody] DistributorsDetailLevel detailLevel)
    {
        GetByCodeDistributorQuery query = new() { Code = code, DetailLevel = detailLevel };

        GetByCodeDistributorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] DistributorsDetailLevel detailLevel)
    {
        GetByIdDistributorQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdDistributorResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest, [FromBody] DistributorsDetailLevel detailLevel)
    {
        GetListDistributorQuery query = new() { PageRequest = pageRequest, DetailLevel = detailLevel };
        GetListResponse<GetListDistributorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DistributorDynamicModel? dynamicModel = null)
    {
        GetListByDynamicDistributorQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicDistributorListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
