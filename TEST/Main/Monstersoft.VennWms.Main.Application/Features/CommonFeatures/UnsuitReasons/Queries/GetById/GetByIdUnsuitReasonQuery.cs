using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetById;

public class GetByIdUnsuitReasonQuery : IRequest<GetByIdUnsuitReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }


    public class GetByIdUnsuitReasonQueryHandler : IRequestHandler<GetByIdUnsuitReasonQuery, GetByIdUnsuitReasonResponse>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdUnsuitReasonQueryHandler(IUnsuitReasonRepository unsuitReasonRepository, IMapper mapper, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _mapper = mapper;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
        }

        public async Task<GetByIdUnsuitReasonResponse> Handle(GetByIdUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdUnsuitReasonResponse>(await _unsuitReasonRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
