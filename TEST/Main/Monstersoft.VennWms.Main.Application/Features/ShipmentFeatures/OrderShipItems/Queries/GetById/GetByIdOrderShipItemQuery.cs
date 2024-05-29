using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetById;

public class GetByIdOrderShipItemQuery : IRequest<GetByIdOrderShipItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderShipItemQueryHandler : IRequestHandler<GetByIdOrderShipItemQuery, GetByIdOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderShipItemQueryHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _mapper = mapper;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<GetByIdOrderShipItemResponse> Handle(GetByIdOrderShipItemQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderShipItemResponse>(await _orderShipItemRepository.GetAsync(x => x.Id == request.Id,
                include: x => x.Include(y => y.OrderShipItemTasks)
                           .Include(y => y.OrderShipItemTasks).ThenInclude(m => m.OrderShipItemStocks),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
