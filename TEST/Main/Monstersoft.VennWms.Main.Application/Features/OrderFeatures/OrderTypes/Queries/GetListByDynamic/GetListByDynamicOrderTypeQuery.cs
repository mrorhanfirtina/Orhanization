using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants.OrderTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetListByDynamic;

public class GetListByDynamicOrderTypeQuery : IRequest<GetListResponse<GetListByDynamicOrderTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderTypeQueryHandler : IRequestHandler<GetListByDynamicOrderTypeQuery, GetListResponse<GetListByDynamicOrderTypeListItemDto>>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderTypeQueryHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _orderTypeBusinessRules = orderTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderTypeListItemDto>> Handle(GetListByDynamicOrderTypeQuery request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderType> orderTypeList = await _orderTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Orders),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderTypeListItemDto>>(orderTypeList);
        }
    }

}
