using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.AuthAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Queries.GetList;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.AuthAPI.Controllers.AuthControllers;

public class UserOperationClaimsController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdUserOperationClaimQuery getByIdUserOperationClaimQuery)
    {
        // Kullanıcıya ait yetki bilgilerini getirir.
        GetByIdUserOperationClaimResponse result = await Mediator.Send(getByIdUserOperationClaimQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        // Kullanıcıya ait yetki bilgilerini getirir.
        GetListUserOperationClaimQuery getListUserOperationClaimQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListUserOperationClaimListItemDto> result = await Mediator.Send(getListUserOperationClaimQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserOperationClaimCommand createUserOperationClaimCommand)
    {
        // Kullanıcıya yetki ekler.
        CreatedUserOperationClaimResponse result = await Mediator.Send(createUserOperationClaimCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserOperationClaimCommand updateUserOperationClaimCommand)
    {
        // Kullanıcıya ait yetki bilgilerini günceller.
        UpdatedUserOperationClaimResponse result = await Mediator.Send(updateUserOperationClaimCommand);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserOperationClaimCommand deleteUserOperationClaimCommand)
    {
        // Kullanıcıya ait yetki bilgilerini siler.
        DeletedUserOperationClaimResponse result = await Mediator.Send(deleteUserOperationClaimCommand);
        return Ok(result);
    }
}
