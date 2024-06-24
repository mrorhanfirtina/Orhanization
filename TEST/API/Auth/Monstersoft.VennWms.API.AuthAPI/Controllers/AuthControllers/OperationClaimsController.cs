using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.AuthAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Queries.GetList;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.AuthAPI.Controllers.AuthControllers;

public class OperationClaimsController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdOperationClaimQuery getByIdOperationClaimQuery)
    {
        // Operasyon yetkisi detaylarını getirir.
        GetByIdOperationClaimResponse result = await Mediator.Send(getByIdOperationClaimQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        // Operasyon yetkilerini getirir.
        GetListOperationClaimQuery getListOperationClaimQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListOperationClaimListItemDto> result = await Mediator.Send(getListOperationClaimQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOperationClaimCommand createOperationClaimCommand)
    {
        // Operasyon yetkisi ekler.
        CreatedOperationClaimResponse result = await Mediator.Send(createOperationClaimCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOperationClaimCommand updateOperationClaimCommand)
    {
        // Operasyon yetkisi günceller.
        UpdatedOperationClaimResponse result = await Mediator.Send(updateOperationClaimCommand);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOperationClaimCommand deleteOperationClaimCommand)
    {
        // Operasyon yetkisi siler.
        DeletedOperationClaimResponse result = await Mediator.Send(deleteOperationClaimCommand);
        return Ok(result);
    }

}
