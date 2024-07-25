using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants.ShipmentTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Delete;

public class DeleteShipmentTypeCommand : IRequest<DeletedShipmentTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ShipmentTypeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetShipmentTypes"];

    public Guid Id { get; set; }


    public class DeleteShipmentTypeCommandHandler : IRequestHandler<DeleteShipmentTypeCommand, DeletedShipmentTypeResponse>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;

        public DeleteShipmentTypeCommandHandler(IShipmentTypeRepository shipmentTypeRepository, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<DeletedShipmentTypeResponse> Handle(DeleteShipmentTypeCommand request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ShipmentType shipmentType = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _shipmentTypeRepository.DeleteAsync(shipmentType);

            return new DeletedShipmentTypeResponse
            {
                Id = shipmentType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ShipmentTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

