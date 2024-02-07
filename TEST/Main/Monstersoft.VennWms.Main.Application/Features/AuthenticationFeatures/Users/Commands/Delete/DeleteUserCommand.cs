using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Security.Entities;
using static Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants.UsersOperationClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Delete;

public class DeleteUserCommand : IRequest<DeletedUserResponse>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { Admin, Write, UsersOperationClaims.Delete };

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeletedUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;

        public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<DeletedUserResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await _userBusinessRules.UserIdShouldExistWhenSelected(request.Id);

            User mappedUser = _mapper.Map<User>(request);
            User deletedUser = await _userRepository.DeleteAsync(mappedUser);
            DeletedUserResponse deletedUserDto = _mapper.Map<DeletedUserResponse>(deletedUser);
            return deletedUserDto;
        }
    }
}