﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;
using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.UpdateFromAuth;

public class UpdateUserFromAuthCommand : IRequest<UpdatedUserFromAuthResponse>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string? NewPassword { get; set; }

    public class UpdateUserFromAuthCommandHandler : IRequestHandler<UpdateUserFromAuthCommand, UpdatedUserFromAuthResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IAuthService _authService;

        public UpdateUserFromAuthCommandHandler(
            IUserRepository userRepository,
            IMapper mapper,
            UserBusinessRules userBusinessRules,
            IAuthService authService
        )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
            _authService = authService;
        }

        public async Task<UpdatedUserFromAuthResponse> Handle(UpdateUserFromAuthCommand request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(u => u.Id == request.Id);
            await _userBusinessRules.UserShouldBeExist(user);
            await _userBusinessRules.UserPasswordShouldBeMatch(user, request.Password);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            if (request.NewPassword is not null && !string.IsNullOrWhiteSpace(request.NewPassword))
            {
                byte[] passwordHash,
                    passwordSalt;
                HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            User updatedUser = await _userRepository.UpdateAsync(user);
            UpdatedUserFromAuthResponse updatedUserFromAuthDto = _mapper.Map<UpdatedUserFromAuthResponse>(updatedUser);
            updatedUserFromAuthDto.AccessToken = await _authService.CreateAccessToken(user);
            return updatedUserFromAuthDto;
        }
    }
}

