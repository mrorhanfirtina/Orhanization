using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetList;

public class GetListShipmentAttributeQuery : IRequest<GetListResponse<GetListShipmentAttributeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListShipmentAttributeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetShipmentAttributes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ShipmentAttributesDetailLevel? DetailLevel { get; set; }


    public class GetListShipmentAttributeQueryHandler : IRequestHandler<GetListShipmentAttributeQuery, GetListResponse<GetListShipmentAttributeListItemDto>>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListShipmentAttributeQueryHandler(IShipmentAttributeRepository shipmentAttributeRepository, IMapper mapper, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _mapper = mapper;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
        }

        public async Task<GetListResponse<GetListShipmentAttributeListItemDto>> Handle(GetListShipmentAttributeQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ShipmentAttribute> shipmentAttributeList = await _shipmentAttributeRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(x => x.DepositorCompany).Include(x => x.AttributeInputType),
            orderBy: x => x.OrderByDescending(m => m.CreatedDate),
            index: request.PageRequest.PageIndex, enableTracking: false,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListShipmentAttributeListItemDto>>(shipmentAttributeList);
        }
    }

}
