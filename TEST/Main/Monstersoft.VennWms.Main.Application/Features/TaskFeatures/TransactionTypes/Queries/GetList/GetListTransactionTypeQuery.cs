using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetList;

public class GetListTransactionTypeQuery : IRequest<GetListResponse<GetListTransactionTypeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListTransactionTypeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetTransactionTypes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListTransactionTypeQueryHandler : IRequestHandler<GetListTransactionTypeQuery, GetListResponse<GetListTransactionTypeListItemDto>>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListTransactionTypeQueryHandler(ITransactionTypeRepository transactionTypeRepository, IMapper mapper, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _mapper = mapper;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
        }

        public async Task<GetListResponse<GetListTransactionTypeListItemDto>> Handle(GetListTransactionTypeQuery request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TransactionType> transactionTypeList = await _transactionTypeRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListTransactionTypeListItemDto>>(transactionTypeList);
        }
    }

}

