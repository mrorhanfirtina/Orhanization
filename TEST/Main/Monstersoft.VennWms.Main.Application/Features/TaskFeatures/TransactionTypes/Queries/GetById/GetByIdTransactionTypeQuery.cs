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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetById;

public class GetByIdTransactionTypeQuery : IRequest<GetByIdTransactionTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public int Id { get; set; }


    public class GetByIdTransactionTypeQueryHandler : IRequestHandler<GetByIdTransactionTypeQuery, GetByIdTransactionTypeResponse>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTransactionTypeQueryHandler(ITransactionTypeRepository transactionTypeRepository, IMapper mapper, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _mapper = mapper;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
        }

        public async Task<GetByIdTransactionTypeResponse> Handle(GetByIdTransactionTypeQuery request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdTransactionTypeResponse>(await _transactionTypeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

