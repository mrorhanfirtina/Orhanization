using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants.OrderAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetList;

public class GetListOrderAttributeQuery : IRequest<GetListResponse<GetListOrderAttributeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListOrderAttributeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetOrderAttributes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListOrderAttributeQueryHandler : IRequestHandler<GetListOrderAttributeQuery, GetListResponse<GetListOrderAttributeListItemDto>>
    {
        private readonly IOrderAttributeRepository _orderAttributeRepository;
        private readonly OrderAttributeBusinessRules _orderAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListOrderAttributeQueryHandler(IOrderAttributeRepository orderAttributeRepository, IMapper mapper, OrderAttributeBusinessRules orderAttributeBusinessRules)
        {
            _orderAttributeRepository = orderAttributeRepository;
            _mapper = mapper;
            _orderAttributeBusinessRules = orderAttributeBusinessRules;
        }

        public async Task<GetListResponse<GetListOrderAttributeListItemDto>> Handle(GetListOrderAttributeQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderAttribute> orderAttributeList = await _orderAttributeRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListOrderAttributeListItemDto>>(orderAttributeList);
        }
    }

}

