using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;

public class GetByIdTransactionLogQuery : IRequest<GetByIdTransactionLogResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdTransactionLogQueryHandler : IRequestHandler<GetByIdTransactionLogQuery, GetByIdTransactionLogResponse>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTransactionLogQueryHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _mapper = mapper;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<GetByIdTransactionLogResponse> Handle(GetByIdTransactionLogQuery request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdTransactionLogResponse>(await _transactionLogRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockAttributeValues)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockContainers)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockReserveReasons)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockUnsuitReasons),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
