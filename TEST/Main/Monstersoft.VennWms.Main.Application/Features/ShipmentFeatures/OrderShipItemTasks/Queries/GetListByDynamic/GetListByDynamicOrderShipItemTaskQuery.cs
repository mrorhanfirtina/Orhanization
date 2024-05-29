using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants.OrderShipItemTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Queries.GetListByDynamic;

public class GetListByDynamicOrderShipItemTaskQuery : IRequest<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicOrderShipItemTaskQueryHandler : IRequestHandler<GetListByDynamicOrderShipItemTaskQuery, GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderShipItemTaskQueryHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, IMapper mapper, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>> Handle(GetListByDynamicOrderShipItemTaskQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<OrderShipItemTask> orderShipItemTaskList = await _orderShipItemTaskRepository.GetListByDynamicAsync(
            include: x => x.Include(y => y.OrderShipItemStocks),
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicOrderShipItemTaskListItemDto>>(orderShipItemTaskList);
        }
    }

}
