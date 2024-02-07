using Amazon.Runtime.Internal;
using MediatR;
using Orhanization.Core.Application.Pipelines.Authorization;
using static Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants.UsersOperationClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Orhanization.Core.Security.Entities;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Rules;
using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Rules;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Rules;
using Orhanization.Core.Security.Hashing;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Dtos;
using System.Text.Json.Serialization;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Create;

public class CreateUserWithClaimsCommand : IRequest<CreatedUserWithClaimsResponse>, ITransactionalRequest, ILocalityRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int[] ClaimIds { get; set; }
    [JsonIgnore]
    public UserRequestInfo UserRequestInfo { get; set; }

    public CreateUserWithClaimsCommand()
    {
        UserRequestInfo = new UserRequestInfo();
    }
    public string[] Roles => new[] { Admin, Write, Add };
}

public class CreateUserWithClaimsCommandHandler : IRequestHandler<CreateUserWithClaimsCommand, CreatedUserWithClaimsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IUserOperationClaimRepository _userOperationClaimRepository;
    private readonly IMapper _mapper;
    private readonly UserBusinessRules _userBusinessRules;
    private readonly OperationClaimBusinessRules _operationClaimBusinessRules;

    public CreateUserWithClaimsCommandHandler(IUserRepository userRepository,
        IUserOperationClaimRepository userOperationClaimRepository, IMapper mapper,
        UserBusinessRules userBusinessRules, 
        OperationClaimBusinessRules operationClaimBusinessRules)
    {
        _userRepository = userRepository;
        _userOperationClaimRepository = userOperationClaimRepository;
        _mapper = mapper;
        _userBusinessRules = userBusinessRules;
        _operationClaimBusinessRules = operationClaimBusinessRules;
    }

    public async Task<CreatedUserWithClaimsResponse> Handle(CreateUserWithClaimsCommand request, CancellationToken cancellationToken)
    {

        // Operasyon claimlerinin tamamının olup olmadığını kontrol et
        await _operationClaimBusinessRules.OperationClaimIdsShouldExistWhenSelected(request.ClaimIds);

        // User emailinin unique olup olmadığını kontrol et
        await _userBusinessRules.EmailShouldBeUnique(request.Email);
        // User şifresinin güçlü olup olmadığını kontrol et
        await _userBusinessRules.PasswordShouldBeStrong(request.Password);

        // Gelen isteği User nesnesine map et
        User mappedUser = _mapper.Map<User>(request);

        // HashingHelper yardımıyla şifreyi hashle
        byte[] passwordHash,
            passwordSalt;
        HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
        mappedUser.PasswordHash = passwordHash;
        mappedUser.PasswordSalt = passwordSalt;
        mappedUser.LocalityId = request.UserRequestInfo.RequestUserLocalityId;

        // User nesnesini veritabanına ekle
        User createdUser = await _userRepository.AddAsync(mappedUser);

        foreach (int claimId in request.ClaimIds)
        {
            // UserOperationClaimleri ekle
            UserOperationClaim userOperationClaim = new(userId: createdUser.Id, operationClaimId: claimId);

            // UserOperationClaim nesnesini veritabanına ekle
            UserOperationClaim operationClaim = await _userOperationClaimRepository.AddAsync(userOperationClaim);
            // UserOperationClaim nesnesini User nesnesine ekle
            createdUser.UserOperationClaims.Add(operationClaim);
        }

        // UserOperationClaim nesnesini oluştur
        CreatedUserWithClaimsResponse createdUserDto = _mapper.Map<CreatedUserWithClaimsResponse>(createdUser);
        return createdUserDto;


    }
}
