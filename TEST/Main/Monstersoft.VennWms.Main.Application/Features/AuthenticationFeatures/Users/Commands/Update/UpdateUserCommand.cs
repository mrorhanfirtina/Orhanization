using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.Hashing;
using static Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants.UsersOperationClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Update;

public class UpdateUserCommand : IRequest<UpdatedUserResponse>, ISecuredRequest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public string[] Roles => new[] { Admin, Write, UsersOperationClaims.Update };

    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdatedUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;

        public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<UpdatedUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User mappedUser = _mapper.Map<User>(request);

            byte[] passwordHash,
                passwordSalt;
            HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);
            mappedUser.PasswordHash = passwordHash;
            mappedUser.PasswordSalt = passwordSalt;

            User updatedUser = await _userRepository.UpdateAsync(mappedUser);
            UpdatedUserResponse updatedUserDto = _mapper.Map<UpdatedUserResponse>(updatedUser);
            return updatedUserDto;
        }
    }
}
