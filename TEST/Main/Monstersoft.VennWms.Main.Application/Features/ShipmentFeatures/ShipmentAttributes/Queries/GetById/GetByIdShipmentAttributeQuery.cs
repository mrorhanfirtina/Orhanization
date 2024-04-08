using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetById;

public class GetByIdShipmentAttributeQuery : IRequest<GetByIdShipmentAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdShipmentAttributeQueryHandler : IRequestHandler<GetByIdShipmentAttributeQuery, GetByIdShipmentAttributeResponse>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentAttributeQueryHandler(IShipmentAttributeRepository shipmentAttributeRepository, IMapper mapper, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _mapper = mapper;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
        }

        public async Task<GetByIdShipmentAttributeResponse> Handle(GetByIdShipmentAttributeQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdShipmentAttributeResponse>(await _shipmentAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
