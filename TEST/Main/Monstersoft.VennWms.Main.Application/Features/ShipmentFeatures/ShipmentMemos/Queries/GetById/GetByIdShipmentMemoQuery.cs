using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants.ShipmentMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetById;

public class GetByIdShipmentMemoQuery : IRequest<GetByIdShipmentMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdShipmentMemoQueryHandler : IRequestHandler<GetByIdShipmentMemoQuery, GetByIdShipmentMemoResponse>
    {
        private readonly IShipmentMemoRepository _shipmentMemoRepository;
        private readonly ShipmentMemoBusinessRules _shipmentMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentMemoQueryHandler(IShipmentMemoRepository shipmentMemoRepository, IMapper mapper, ShipmentMemoBusinessRules shipmentMemoBusinessRules)
        {
            _shipmentMemoRepository = shipmentMemoRepository;
            _mapper = mapper;
            _shipmentMemoBusinessRules = shipmentMemoBusinessRules;
        }

        public async Task<GetByIdShipmentMemoResponse> Handle(GetByIdShipmentMemoQuery request, CancellationToken cancellationToken)
        {
            _shipmentMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdShipmentMemoResponse>(await _shipmentMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
