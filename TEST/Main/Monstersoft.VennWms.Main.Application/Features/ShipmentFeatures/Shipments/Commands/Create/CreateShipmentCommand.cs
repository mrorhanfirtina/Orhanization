using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;

public class CreateShipmentCommand : IRequest<CreatedShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipments";

    public CreateShipmentDto Shipment { get; set; }

    public class CreateShipmentCommandHandler : IRequestHandler<CreateShipmentCommand, CreatedShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly IMapper _mapper;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;

        public CreateShipmentCommandHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<CreatedShipmentResponse> Handle(CreateShipmentCommand request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Shipment? shipment = _mapper.Map<Shipment>(request.Shipment);

            shipment.CreatedDate = DateTime.Now;
            shipment.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            shipment.ShipmentMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            shipment.ShipmentAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            return _mapper.Map<CreatedShipmentResponse>(await _shipmentRepository.AddAsync(shipment));
        }
    }
}
