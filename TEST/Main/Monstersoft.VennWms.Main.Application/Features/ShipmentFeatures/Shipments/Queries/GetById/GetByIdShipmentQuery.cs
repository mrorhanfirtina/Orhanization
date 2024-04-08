using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;

public class GetByIdShipmentQuery : IRequest<GetByIdShipmentResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdShipmentQueryHandler : IRequestHandler<GetByIdShipmentQuery, GetByIdShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentQueryHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<GetByIdShipmentResponse> Handle(GetByIdShipmentQuery request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdShipmentResponse>(await _shipmentRepository.GetAsync(x => x.Id == request.Id, withDeleted: false,
                include: m => m.Include(x => x.Distributor).Include(x => x.Branch).Include(x => x.ShipmentAttributeValues).Include(x => x.ShipmentMemos),
                cancellationToken: cancellationToken));
        }
    }

}
