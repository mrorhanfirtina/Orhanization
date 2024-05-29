﻿using AutoMapper;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetByCode;

public class GetByCodeShipmentQuery : IRequest<GetByCodeShipmentResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeShipmentQueryHandler : IRequestHandler<GetByCodeShipmentQuery, GetByCodeShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeShipmentQueryHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<GetByCodeShipmentResponse> Handle(GetByCodeShipmentQuery request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeShipmentResponse>(await _shipmentRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(y => y.ShipmentMemos)
            .Include(y => y.ShipmentAttributeValues),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
