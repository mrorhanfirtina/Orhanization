using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.AuthAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.UpdateFromAuth;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Queries.GetList;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

namespace Monstersoft.VennWms.API.AuthAPI.Controllers.AuthControllers;

public class UsersController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdUserQuery getByIdUserQuery)
    {
        // Id numarsına göre kullanıcı bilgilerini getirir.
        GetByIdUserResponse result = await Mediator.Send(getByIdUserQuery);
        return Ok(result);
    }

    [HttpGet("GetFromAuth")]
    public async Task<IActionResult> GetFromAuth()
    {
        // Token içerisindeki kullanıcı bilgilerini getirir.
        GetByIdUserQuery getByIdUserQuery = new() { Id = getUserIdFromRequest() };
        GetByIdUserResponse result = await Mediator.Send(getByIdUserQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        // Kullanıcı listesini getirir.
        GetListUserQuery getListUserQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListUserListItemDto> result = await Mediator.Send(getListUserQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
    {
        // Yeni kullanıcı oluşturur.
        CreatedUserResponse result = await Mediator.Send(createUserCommand);
        return Created(uri: "", result);
    }

    [HttpPost("WithClaims")]
    public async Task<IActionResult> AddWithClaims([FromBody] CreateUserWithClaimsCommand createUserWithClaimsCommand)
    {
        // Yeni kullanıcı oluşturur.
        CreatedUserWithClaimsResponse result = await Mediator.Send(createUserWithClaimsCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
    {
        // Kullanıcı bilgilerini günceller.
        UpdatedUserResponse result = await Mediator.Send(updateUserCommand);
        return Ok(result);
    }

    [HttpPut("FromAuth")]
    public async Task<IActionResult> UpdateFromAuth([FromBody] UpdateUserFromAuthCommand updateUserFromAuthCommand)
    {
        // Token içerisindeki kullanıcı bilgilerini günceller.
        updateUserFromAuthCommand.Id = getUserIdFromRequest();
        UpdatedUserFromAuthResponse result = await Mediator.Send(updateUserFromAuthCommand);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserCommand deleteUserCommand)
    {
        // Kullanıcıyı siler.
        DeletedUserResponse result = await Mediator.Send(deleteUserCommand);
        return Ok(result);
    }
}
