using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Delete;

public class DeleteShipmentCommand : IRequest<DeletedShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ShipmentOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipments";

    public Guid Id { get; set; }


    public class DeleteShipmentCommandHandler : IRequestHandler<DeleteShipmentCommand, DeletedShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;

        public DeleteShipmentCommandHandler(IShipmentRepository shipmentRepository, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<DeletedShipmentResponse> Handle(DeleteShipmentCommand request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Shipment shipment = await _shipmentRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _shipmentRepository.DeleteAsync(shipment);

            return new DeletedShipmentResponse
            {
                Id = shipment.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = shipment.DepositorId,
                IsSuccess = true,
                Message = ShipmentMessages.RequestExecutedSuccessfully
            };
        }
    }
}
