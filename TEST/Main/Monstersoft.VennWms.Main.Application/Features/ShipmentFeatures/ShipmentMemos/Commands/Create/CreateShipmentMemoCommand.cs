using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Create;

public class CreateShipmentMemoCommand : IRequest<CreatedShipmentMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentMemos";

    public CreateShipmentMemoDto ShipmentMemo { get; set; }


    public class CreateShipmentMemoCommandHandler : IRequestHandler<CreateShipmentMemoCommand, CreatedShipmentMemoResponse>
    {
        private readonly IShipmentMemoRepository _shipmentMemoRepository;
        private readonly ShipmentMemoBusinessRules _shipmentMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateShipmentMemoCommandHandler(IShipmentMemoRepository shipmentMemoRepository, IMapper mapper, ShipmentMemoBusinessRules shipmentMemoBusinessRules)
        {
            _shipmentMemoRepository = shipmentMemoRepository;
            _mapper = mapper;
            _shipmentMemoBusinessRules = shipmentMemoBusinessRules;
        }

        public async Task<CreatedShipmentMemoResponse> Handle(CreateShipmentMemoCommand request, CancellationToken cancellationToken)
        {
            _shipmentMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckShipmentIdExistence(request.ShipmentMemo.ShipmentId);

            ShipmentMemo shipmentMemo = _mapper.Map<ShipmentMemo>(request.ShipmentMemo);
            shipmentMemo.Id = Guid.NewGuid();
            shipmentMemo.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedShipmentMemoResponse>(await _shipmentMemoRepository.AddAsync(shipmentMemo));
        }
    }
}
