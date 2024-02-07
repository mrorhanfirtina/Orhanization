using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Queries.GetById;

public class GetByIdUserOperationClaimQuery : IRequest<GetByIdUserOperationClaimResponse>
{
    public int Id { get; set; }

    public class GetByIdUserOperationClaimQueryHandler : IRequestHandler<GetByIdUserOperationClaimQuery, GetByIdUserOperationClaimResponse>
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly IMapper _mapper;
        private readonly UserOperationClaimBusinessRules _userOperationClaimBusinessRules;

        public GetByIdUserOperationClaimQueryHandler(
            IUserOperationClaimRepository userOperationClaimRepository,
            IMapper mapper,
            UserOperationClaimBusinessRules userOperationClaimBusinessRules
        )
        {
            _userOperationClaimRepository = userOperationClaimRepository;
            _mapper = mapper;
            _userOperationClaimBusinessRules = userOperationClaimBusinessRules;
        }

        public async Task<GetByIdUserOperationClaimResponse> Handle(
            GetByIdUserOperationClaimQuery request,
            CancellationToken cancellationToken
        )
        {
            await _userOperationClaimBusinessRules.UserOperationClaimIdShouldExistWhenSelected(request.Id);

            UserOperationClaim? userOperationClaim = await _userOperationClaimRepository.GetAsync(b => b.Id == request.Id);
            GetByIdUserOperationClaimResponse userOperationClaimDto = _mapper.Map<GetByIdUserOperationClaimResponse>(userOperationClaim);
            return userOperationClaimDto;
        }
    }
}
