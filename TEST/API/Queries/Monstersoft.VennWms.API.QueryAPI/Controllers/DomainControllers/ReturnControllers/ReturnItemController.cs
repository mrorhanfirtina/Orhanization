using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.ReturnControllers;

public class ReturnItemController : BaseController
{
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id, [FromBody] ReturnItemsDetailLevel detailLevel)
    {
        GetByIdReturnItemQuery query = new() { Id = id, DetailLevel = detailLevel };

        GetByIdReturnItemResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] ReturnItemDynamicModel? dynamicModel = null)
    {
        GetListByDynamicReturnItemQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicModel.DynamicQuery, DetailLevel = dynamicModel.DetailLevel };
        GetListResponse<GetListByDynamicReturnItemListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
