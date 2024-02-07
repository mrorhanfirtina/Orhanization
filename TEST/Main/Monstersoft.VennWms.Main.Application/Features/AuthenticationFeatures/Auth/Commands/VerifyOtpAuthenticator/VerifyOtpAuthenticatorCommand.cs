using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;
using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.VerifyOtpAuthenticator;

public class VerifyOtpAuthenticatorCommand : IRequest
{
    public int UserId { get; set; }
    public string ActivationCode { get; set; }

    public class VerifyOtpAuthenticatorCommandHandler : IRequestHandler<VerifyOtpAuthenticatorCommand>
    {
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IAuthenticatorService _authenticatorService;
        private readonly IOtpAuthenticatorRepository _otpAuthenticatorRepository;
        private readonly IUserService _userService;

        public VerifyOtpAuthenticatorCommandHandler(
            IOtpAuthenticatorRepository otpAuthenticatorRepository,
            AuthBusinessRules authBusinessRules,
            IUserService userService,
            IAuthenticatorService authenticatorService
        )
        {
            _otpAuthenticatorRepository = otpAuthenticatorRepository;
            _authBusinessRules = authBusinessRules;
            _userService = userService;
            _authenticatorService = authenticatorService;
        }

        public async Task Handle(VerifyOtpAuthenticatorCommand request, CancellationToken cancellationToken)
        {
            OtpAuthenticator? otpAuthenticator = await _otpAuthenticatorRepository.GetAsync(e => e.UserId == request.UserId);
            await _authBusinessRules.OtpAuthenticatorShouldBeExists(otpAuthenticator);

            User user = await _userService.GetById(request.UserId);

            otpAuthenticator.IsVerified = true;
            user.AuthenticatorType = AuthenticatorType.Otp;

            await _authenticatorService.VerifyAuthenticatorCode(user, request.ActivationCode);

            await _otpAuthenticatorRepository.UpdateAsync(otpAuthenticator);
            await _userService.Update(user);
        }
    }
}

