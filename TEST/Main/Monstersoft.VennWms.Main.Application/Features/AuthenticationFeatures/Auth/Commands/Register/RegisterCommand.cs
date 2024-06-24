using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Rules;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.Hashing;
using Orhanization.Core.Security.JWT;
using System.Security.Claims;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.Register;

public class RegisterCommand : IRequest<RegisteredResponse>
{
    public UserForRegisterDto UserForRegisterDto { get; set; }
    public string IPAddress { get; set; }

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly OperationClaimBusinessRules _operationClaimBusinessRules;
        private readonly IAuthService _authService;
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IUserDepositorRepository _userDepositorRepository;

        public RegisterCommandHandler(IUserRepository userRepository, IAuthService authService, AuthBusinessRules authBusinessRules,
            OperationClaimBusinessRules operationClaimBusinessRules, IUserOperationClaimRepository userOperationClaimRepository, IUserDepositorRepository userDepositorRepository)
        {
            _userRepository = userRepository;
            _authService = authService;
            _authBusinessRules = authBusinessRules;
            _operationClaimBusinessRules = operationClaimBusinessRules;
            _userOperationClaimRepository = userOperationClaimRepository;
            _userDepositorRepository = userDepositorRepository;
        }

        public async Task<RegisteredResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.UserEmailShouldBeNotExists(request.UserForRegisterDto.Email);

            await _operationClaimBusinessRules.OperationClaimIdsShouldExistWhenSelected(request.UserForRegisterDto.UserOperationClaimIds);

            byte[] passwordHash,
                passwordSalt;
            HashingHelper.CreatePasswordHash(request.UserForRegisterDto.Password, out passwordHash, out passwordSalt);
            User newUser =
                new()
                {
                    Email = request.UserForRegisterDto.Email,
                    FirstName = request.UserForRegisterDto.FirstName,
                    LastName = request.UserForRegisterDto.LastName,
                    LocalityId = request.UserForRegisterDto.LocalityId,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true
                };
            User createdUser = await _userRepository.AddAsync(newUser);

            foreach (int claimId in request.UserForRegisterDto.UserOperationClaimIds)
            {
                // UserOperationClaimleri ekle
                UserOperationClaim userOperationClaim = new(userId: createdUser.Id, operationClaimId: claimId);

                // UserOperationClaim nesnesini veritabanına ekle
                UserOperationClaim operationClaim = await _userOperationClaimRepository.AddAsync(userOperationClaim);
                // UserOperationClaim nesnesini User nesnesine ekle
                createdUser.UserOperationClaims.Add(operationClaim);
            }

            foreach (Guid depositorId in request.UserForRegisterDto.UserLocalityIds)
            {
                UserDepositor userDepositor = new(id: Guid.NewGuid(), userId: createdUser.Id, depositorId: depositorId);
                UserDepositor createdUserDepositor = await _userDepositorRepository.AddAsync(userDepositor);
            }

            AccessToken createdAccessToken = await _authService.CreateAccessToken(createdUser);

            RefreshToken createdRefreshToken = await _authService.CreateRefreshToken(createdUser, request.IPAddress);
            RefreshToken addedRefreshToken = await _authService.AddRefreshToken(createdRefreshToken);

            RegisteredResponse registeredResponse = new() { AccessToken = createdAccessToken, RefreshToken = addedRefreshToken };
            return registeredResponse;
        }
    }
}
