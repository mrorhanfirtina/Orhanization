using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants.OrderTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetList;

public class GetListOrderTypeQuery : IRequest<GetListResponse<GetListOrderTypeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListOrderTypeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetOrderTypes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }



    public class GetListOrderTypeQueryHandler : IRequestHandler<GetListOrderTypeQuery, GetListResponse<GetListOrderTypeListItemDto>>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListOrderTypeQueryHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _mapper = mapper;
            _orderTypeBusinessRules = orderTypeBusinessRules;
        }

        public async Task<GetListResponse<GetListOrderTypeListItemDto>> Handle(GetListOrderTypeQuery request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderType> orderTypeList = await _orderTypeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(x => x.DepositorCompany),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListOrderTypeListItemDto>>(orderTypeList);
        }
    }
}
