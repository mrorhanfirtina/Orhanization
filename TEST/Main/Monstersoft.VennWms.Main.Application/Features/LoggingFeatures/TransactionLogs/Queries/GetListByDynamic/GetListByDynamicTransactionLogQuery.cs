using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetListByDynamic;

public class GetListByDynamicTransactionLogQuery : IRequest<GetListResponse<GetListByDynamicTransactionLogListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicTransactionLogQueryHandler : IRequestHandler<GetListByDynamicTransactionLogQuery, GetListResponse<GetListByDynamicTransactionLogListItemDto>>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTransactionLogQueryHandler(ITransactionLogRepository transactionLogRepository, IMapper mapper, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _transactionLogBusinessRules = transactionLogBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTransactionLogListItemDto>> Handle(GetListByDynamicTransactionLogQuery request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TransactionLog> transactionLogList = await _transactionLogRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockAttributeValues)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockContainers)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockReserveReasons)
                .Include(x => x.LogStocks).ThenInclude(ls => ls.LogStockUnsuitReasons),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicTransactionLogListItemDto>>(transactionLogList);
        }
    }

}
