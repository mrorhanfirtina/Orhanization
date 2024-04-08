using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants.OrderAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetListByDynamic;

public class GetListByDynamicOrderAttributeQuery : IRequest<GetListResponse<GetListByDynamicOrderAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderAttributeQueryHandler : IRequestHandler<GetListByDynamicOrderAttributeQuery, GetListResponse<GetListByDynamicOrderAttributeListItemDto>>
    {
        private readonly IOrderAttributeRepository _orderAttributeRepository;
        private readonly OrderAttributeBusinessRules _orderAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderAttributeQueryHandler(IOrderAttributeRepository orderAttributeRepository, IMapper mapper, OrderAttributeBusinessRules orderAttributeBusinessRules)
        {
            _orderAttributeRepository = orderAttributeRepository;
            _orderAttributeBusinessRules = orderAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderAttributeListItemDto>> Handle(GetListByDynamicOrderAttributeQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderAttribute> orderAttributeList = await _orderAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderAttributeListItemDto>>(orderAttributeList);
        }
    }

}

