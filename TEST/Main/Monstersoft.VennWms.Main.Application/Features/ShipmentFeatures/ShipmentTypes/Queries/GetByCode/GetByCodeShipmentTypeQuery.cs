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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetByCode;

public class GetByCodeShipmentTypeQuery : IRequest<GetByCodeShipmentTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeShipmentTypeQueryHandler : IRequestHandler<GetByCodeShipmentTypeQuery, GetByCodeShipmentTypeResponse>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeShipmentTypeQueryHandler(IShipmentTypeRepository shipmentTypeRepository, IMapper mapper, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _mapper = mapper;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<GetByCodeShipmentTypeResponse> Handle(GetByCodeShipmentTypeQuery request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeShipmentTypeResponse>(await _shipmentTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Shipments),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

