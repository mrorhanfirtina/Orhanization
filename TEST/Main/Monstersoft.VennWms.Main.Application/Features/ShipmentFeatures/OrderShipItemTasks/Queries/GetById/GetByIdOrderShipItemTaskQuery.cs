using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants.OrderShipItemTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Queries.GetById;

public class GetByIdOrderShipItemTaskQuery : IRequest<GetByIdOrderShipItemTaskResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderShipItemTaskQueryHandler : IRequestHandler<GetByIdOrderShipItemTaskQuery, GetByIdOrderShipItemTaskResponse>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderShipItemTaskQueryHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, IMapper mapper, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _mapper = mapper;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
        }

        public async Task<GetByIdOrderShipItemTaskResponse> Handle(GetByIdOrderShipItemTaskQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderShipItemTaskResponse>(await _orderShipItemTaskRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.OrderShipItemStocks),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
