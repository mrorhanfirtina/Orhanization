using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;


namespace Monstersoft.VennWms.API.QueryAPI.Controllers.DomainControllers.TaskControllers;

public class TransactionTypeController : BaseController
{
    [HttpGet("GetByCode/{code}")]
    public async Task<IActionResult> GetByCodeAsync([FromRoute] string code)
    {
        GetByCodeTransactionTypeQuery query = new() { Code = code };

        GetByCodeTransactionTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        GetByIdTransactionTypeQuery query = new() { Id = id };

        GetByIdTransactionTypeResponse result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTransactionTypeQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListTransactionTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

    [HttpPost("GetListByDynamic")]
    public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
    {
        GetListByDynamicTransactionTypeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
        GetListResponse<GetListByDynamicTransactionTypeListItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }

}
