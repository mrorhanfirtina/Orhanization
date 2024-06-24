﻿using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.EnableOtpAuthenticator;

public class EnableOtpAuthenticatorCommand : IRequest<EnabledOtpAuthenticatorResponse>
{
    public int UserId { get; set; }

    public class EnableOtpAuthenticatorCommandHandler : IRequestHandler<EnableOtpAuthenticatorCommand, EnabledOtpAuthenticatorResponse>
    {
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IAuthenticatorService _authenticatorService;
        private readonly IOtpAuthenticatorRepository _otpAuthenticatorRepository;
        private readonly IUserService _userService;

        public EnableOtpAuthenticatorCommandHandler(
            IUserService userService,
            IOtpAuthenticatorRepository otpAuthenticatorRepository,
            AuthBusinessRules authBusinessRules,
            IAuthenticatorService authenticatorService
        )
        {
            _userService = userService;
            _otpAuthenticatorRepository = otpAuthenticatorRepository;
            _authBusinessRules = authBusinessRules;
            _authenticatorService = authenticatorService;
        }

        public async Task<EnabledOtpAuthenticatorResponse> Handle(
            EnableOtpAuthenticatorCommand request,
            CancellationToken cancellationToken
        )
        {
            User user = await _userService.GetById(request.UserId);
            await _authBusinessRules.UserShouldBeExists(user);
            await _authBusinessRules.UserShouldNotBeHaveAuthenticator(user);

            OtpAuthenticator? isExistsOtpAuthenticator = await _otpAuthenticatorRepository.GetAsync(o => o.UserId == request.UserId);
            await _authBusinessRules.OtpAuthenticatorThatVerifiedShouldNotBeExists(isExistsOtpAuthenticator);
            if (isExistsOtpAuthenticator is not null)
                await _otpAuthenticatorRepository.DeleteAsync(isExistsOtpAuthenticator);

            OtpAuthenticator newOtpAuthenticator = await _authenticatorService.CreateOtpAuthenticator(user);
            OtpAuthenticator addedOtpAuthenticator = await _otpAuthenticatorRepository.AddAsync(newOtpAuthenticator);

            EnabledOtpAuthenticatorResponse enabledOtpAuthenticatorDto =
                new() { SecretKey = await _authenticatorService.ConvertSecretKeyToString(addedOtpAuthenticator.SecretKey) };
            return enabledOtpAuthenticatorDto;
        }
    }
}

