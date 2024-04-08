using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetByCode;

public class GetByCodeTransactionTypeQuery : IRequest<GetByCodeTransactionTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeTransactionTypeQueryHandler : IRequestHandler<GetByCodeTransactionTypeQuery, GetByCodeTransactionTypeResponse>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeTransactionTypeQueryHandler(ITransactionTypeRepository transactionTypeRepository, IMapper mapper, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _mapper = mapper;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
        }

        public async Task<GetByCodeTransactionTypeResponse> Handle(GetByCodeTransactionTypeQuery request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeTransactionTypeResponse>(await _transactionTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

