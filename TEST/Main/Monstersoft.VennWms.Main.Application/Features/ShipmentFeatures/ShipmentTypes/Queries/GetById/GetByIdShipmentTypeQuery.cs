using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants.ShipmentTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetById;

public class GetByIdShipmentTypeQuery : IRequest<GetByIdShipmentTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdShipmentTypeQueryHandler : IRequestHandler<GetByIdShipmentTypeQuery, GetByIdShipmentTypeResponse>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentTypeQueryHandler(IShipmentTypeRepository shipmentTypeRepository, IMapper mapper, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _mapper = mapper;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<GetByIdShipmentTypeResponse> Handle(GetByIdShipmentTypeQuery request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdShipmentTypeResponse>(await _shipmentTypeRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.Shipments),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

