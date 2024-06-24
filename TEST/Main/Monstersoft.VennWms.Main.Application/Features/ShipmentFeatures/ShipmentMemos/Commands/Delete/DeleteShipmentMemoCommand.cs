using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants.ShipmentMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Delete;

public class DeleteShipmentMemoCommand : IRequest<DeletedShipmentMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ShipmentMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentMemos";

    public Guid Id { get; set; }


    public class DeleteShipmentMemoCommandHandler : IRequestHandler<DeleteShipmentMemoCommand, DeletedShipmentMemoResponse>
    {
        private readonly IShipmentMemoRepository _shipmentMemoRepository;
        private readonly ShipmentMemoBusinessRules _shipmentMemoBusinessRules;

        public DeleteShipmentMemoCommandHandler(IShipmentMemoRepository shipmentMemoRepository, ShipmentMemoBusinessRules shipmentMemoBusinessRules)
        {
            _shipmentMemoRepository = shipmentMemoRepository;
            _shipmentMemoBusinessRules = shipmentMemoBusinessRules;
        }

        public async Task<DeletedShipmentMemoResponse> Handle(DeleteShipmentMemoCommand request, CancellationToken cancellationToken)
        {
            _shipmentMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ShipmentMemo shipmentMemo = await _shipmentMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _shipmentMemoRepository.DeleteAsync(shipmentMemo);

            return new DeletedShipmentMemoResponse
            {
                Id = shipmentMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ShipmentMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}
