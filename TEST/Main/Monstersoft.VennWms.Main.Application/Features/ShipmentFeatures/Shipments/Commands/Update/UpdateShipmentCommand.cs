using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;

public class UpdateShipmentCommand : IRequest<UpdatedShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipments";

    public UpdateShipmentDto Shipment { get; set; }

    public class UpdateShipmentCommandHandler : IRequestHandler<UpdateShipmentCommand, UpdatedShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly IMapper _mapper;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;

        public UpdateShipmentCommandHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<UpdatedShipmentResponse> Handle(UpdateShipmentCommand request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Shipment.Id);

            Shipment? currentShipment = await _shipmentRepository.GetAsync(predicate: x => x.Id == request.Shipment.Id,
            include: x => x.Include(y => y.ShipmentMemos)
            .Include(y => y.ShipmentAttributeValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Shipment? shipment = _mapper.Map(request.Shipment, currentShipment);
            shipment.UpdatedDate = DateTime.Now;

            shipment.ShipmentAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = shipment.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            shipment.ShipmentMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = shipment.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            return _mapper.Map<UpdatedShipmentResponse>(await _shipmentRepository.UpdateAsync(shipment));
        }
    }
}
