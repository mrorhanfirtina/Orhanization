using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Monstersoft.VennWms.API.AuthAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.EnableEmailAuthenticator;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.EnableOtpAuthenticator;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.Login;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.RefreshTokens;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.Register;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.RevokeToken;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.VerifyEmailAuthenticator;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.VerifyOtpAuthenticator;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.API.AuthAPI.Controllers.AuthControllers;

public class AuthController : BaseController
{
    private readonly WebAPIConfiguration _configuration;

    public AuthController(IConfiguration configuration)
    {
        _configuration = configuration.GetSection("WebAPIConfiguration").Get<WebAPIConfiguration>();
    }

    private string? getRefreshTokenFromCookies() => Request.Cookies["refreshToken"];

    private void setRefreshTokenToCookie(RefreshToken refreshToken)
    {
        CookieOptions cookieOptions = new() { HttpOnly = true, Expires = DateTime.UtcNow.AddDays(7) };
        Response.Cookies.Append(key: "refreshToken", refreshToken.Token, cookieOptions);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UserForLoginDto userForLoginDto)
    {
        // Burada kullanıcı adı ve şifre ile giriş yapılır.
        LoginCommand loginCommand = new() { UserForLoginDto = userForLoginDto, IPAddress = getIpAddress() };
        LoggedResponse result = await Mediator.Send(loginCommand);

        if (result.RefreshToken is not null)
            setRefreshTokenToCookie(result.RefreshToken);

        return Ok(result.ToHttpResponse());
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] UserForRegisterDto userForRegisterDto)
    {
        // Burada kullanıcı kaydı yapılır.
        RegisterCommand registerCommand = new() { UserForRegisterDto = userForRegisterDto, IPAddress = getIpAddress() };
        RegisteredResponse result = await Mediator.Send(registerCommand);
        setRefreshTokenToCookie(result.RefreshToken);
        return Created(uri: "", result.AccessToken);
    }

    [HttpGet("RefreshToken")]
    public async Task<IActionResult> RefreshToken()
    {
        // Burada refresh token ile yeni bir access token oluşturulur.
        RefreshTokenCommand refreshTokenCommand = new() { RefleshToken = getRefreshTokenFromCookies(), IPAddress = getIpAddress() };
        RefreshedTokensResponse result = await Mediator.Send(refreshTokenCommand);
        setRefreshTokenToCookie(result.RefreshToken);
        return Created(uri: "", result.AccessToken);
    }

    [HttpPut("RevokeToken")]
    public async Task<IActionResult> RevokeToken([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] string? refreshToken)
    {
        // Burada token geçersiz kılınır.
        RevokeTokenCommand revokeTokenCommand = new() { Token = refreshToken ?? getRefreshTokenFromCookies(), IPAddress = getIpAddress() };
        RevokedTokenResponse result = await Mediator.Send(revokeTokenCommand);
        return Ok(result);
    }

    [HttpGet("EnableEmailAuthenticator")]
    public async Task<IActionResult> EnableEmailAuthenticator()
    {
        // Burada kullanıcıya email ile doğrulama kodu gönderilir.
        EnableEmailAuthenticatorCommand enableEmailAuthenticatorCommand =
            new() { UserId = getUserIdFromRequest(), VerifyEmailUrlPrefix = $"{_configuration.APIDomain}/Auth/VerifyEmailAuthenticator" };
        await Mediator.Send(enableEmailAuthenticatorCommand);

        return Ok();
    }

    [HttpGet("EnableOtpAuthenticator")]
    public async Task<IActionResult> EnableOtpAuthenticator()
    {
        // Burada kullanıcıya otp ile doğrulama kodu gönderilir.
        EnableOtpAuthenticatorCommand enableOtpAuthenticatorCommand = new() { UserId = getUserIdFromRequest() };
        EnabledOtpAuthenticatorResponse result = await Mediator.Send(enableOtpAuthenticatorCommand);

        return Ok(result);
    }

    [HttpGet("VerifyEmailAuthenticator")]
    public async Task<IActionResult> VerifyEmailAuthenticator([FromQuery] VerifyEmailAuthenticatorCommand verifyEmailAuthenticatorCommand)
    {
        // Burada kullanıcının email ile doğrulama kodu kontrol edilir.
        await Mediator.Send(verifyEmailAuthenticatorCommand);
        return Ok();
    }

    [HttpPost("VerifyOtpAuthenticator")]
    public async Task<IActionResult> VerifyOtpAuthenticator([FromBody] string authenticatorCode)
    {
        // Burada kullanıcının otp ile doğrulama kodu kontrol edilir.
        VerifyOtpAuthenticatorCommand verifyEmailAuthenticatorCommand =
            new() { UserId = getUserIdFromRequest(), ActivationCode = authenticatorCode };

        await Mediator.Send(verifyEmailAuthenticatorCommand);
        return Ok();
    }
}
