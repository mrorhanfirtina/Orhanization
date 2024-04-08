using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetListByDynamic;

public class GetListByDynamicTransactionTypeQuery : IRequest<GetListResponse<GetListByDynamicTransactionTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicTransactionTypeQueryHandler : IRequestHandler<GetListByDynamicTransactionTypeQuery, GetListResponse<GetListByDynamicTransactionTypeListItemDto>>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTransactionTypeQueryHandler(ITransactionTypeRepository transactionTypeRepository, IMapper mapper, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTransactionTypeListItemDto>> Handle(GetListByDynamicTransactionTypeQuery request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TransactionType> transactionTypeList = await _transactionTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicTransactionTypeListItemDto>>(transactionTypeList);
        }
    }

}

