using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants.UserDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetById;

public class GetByIdUserDepositorQuery : IRequest<GetByIdUserDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, UserDepositorOperationClaims.User, Read];

    public Guid Id { get; set; }

    public class GetByIdUserDepositorQueryHandler : IRequestHandler<GetByIdUserDepositorQuery, GetByIdUserDepositorResponse>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdUserDepositorQueryHandler(IUserDepositorRepository userDepositorRepository, IMapper mapper, UserDepositorBusinessRules userDepositorBusinessRules)
        {
            _userDepositorRepository = userDepositorRepository;
            _mapper = mapper;
            _userDepositorBusinessRules = userDepositorBusinessRules;
        }

        public async Task<GetByIdUserDepositorResponse> Handle(GetByIdUserDepositorQuery request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdUserDepositorResponse>(await _userDepositorRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
