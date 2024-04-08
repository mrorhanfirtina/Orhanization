using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetById;

public class GetByIdDepositorQuery : IRequest<GetByIdDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdDepositorQueryHandler : IRequestHandler<GetByIdDepositorQuery, GetByIdDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdDepositorQueryHandler(IDepositorRepository depositorRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _mapper = mapper;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<GetByIdDepositorResponse> Handle(GetByIdDepositorQuery request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdDepositorResponse>(await _depositorRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
