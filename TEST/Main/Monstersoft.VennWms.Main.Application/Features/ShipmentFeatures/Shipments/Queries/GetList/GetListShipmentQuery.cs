using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetList;

public class GetListShipmentQuery : IRequest<GetListResponse<GetListShipmentListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListShipmentQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetShipments";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListShipmentQueryHandler : IRequestHandler<GetListShipmentQuery, GetListResponse<GetListShipmentListItemDto>>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetListShipmentQueryHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<GetListResponse<GetListShipmentListItemDto>> Handle(GetListShipmentQuery request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Shipment> shipmentList = await _shipmentRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Distributor).Include(x => x.Branch).Include(x => x.ShipmentAttributeValues).Include(x => x.ShipmentMemos),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListShipmentListItemDto>>(shipmentList);
        }
    }

}
