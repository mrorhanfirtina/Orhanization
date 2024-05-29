using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;

public class CreateOrderShipmentCommand : IRequest<CreatedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipments";

    public CreateOrderShipmentDto OrderShipment { get; set; }


    public class CreateOrderShipmentCommandHandler : IRequestHandler<CreateOrderShipmentCommand, CreatedOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;

        public CreateOrderShipmentCommandHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<CreatedOrderShipmentResponse> Handle(CreateOrderShipmentCommand request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            OrderShipment? orderShipment = _mapper.Map<OrderShipment>(request.OrderShipment);

            orderShipment.CreatedDate = DateTime.Now;
            orderShipment.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            orderShipment.OrderShipItems.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            return _mapper.Map<CreatedOrderShipmentResponse>(await _orderShipmentRepository.AddAsync(orderShipment));
        }
    }
}
