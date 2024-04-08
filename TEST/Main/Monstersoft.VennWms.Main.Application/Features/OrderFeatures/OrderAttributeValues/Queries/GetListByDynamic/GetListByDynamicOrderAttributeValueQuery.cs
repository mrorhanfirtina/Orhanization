using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants.OrderAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicOrderAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicOrderAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }

    public class GetListByDynamicOrderAttributeValueQueryHandler : IRequestHandler<GetListByDynamicOrderAttributeValueQuery, GetListResponse<GetListByDynamicOrderAttributeValueListItemDto>>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderAttributeValueQueryHandler(IOrderAttributeValueRepository orderAttributeValueRepository, IMapper mapper, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderAttributeValueListItemDto>> Handle(GetListByDynamicOrderAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderAttributeValue> orderAttributeValueList = await _orderAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderAttributeValueListItemDto>>(orderAttributeValueList);
        }
    }

}
