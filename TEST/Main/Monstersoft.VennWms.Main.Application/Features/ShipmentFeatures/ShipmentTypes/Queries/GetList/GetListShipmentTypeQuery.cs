using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants.ShipmentTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Queries.GetList;

public class GetListShipmentTypeQuery : IRequest<GetListResponse<GetListShipmentTypeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListShipmentTypeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetShipmentTypes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ShipmentTypesDetailLevel? DetailLevel { get; set; }


    public class GetListShipmentTypeQueryHandler : IRequestHandler<GetListShipmentTypeQuery, GetListResponse<GetListShipmentTypeListItemDto>>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListShipmentTypeQueryHandler(IShipmentTypeRepository shipmentTypeRepository, IMapper mapper, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _mapper = mapper;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<GetListResponse<GetListShipmentTypeListItemDto>> Handle(GetListShipmentTypeQuery request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ShipmentType> shipmentTypeList = await _shipmentTypeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<ShipmentType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeShipment)
                    {
                        query = query.Include(y => y.Shipments);
                    }


                    var includableQuery = query as IIncludableQueryable<ShipmentType, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListShipmentTypeListItemDto>>(shipmentTypeList);
            }
            else
            {
                Paginate<ShipmentType> shipmentTypeList = await _shipmentTypeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListShipmentTypeListItemDto>>(shipmentTypeList);
            }
        }
    }

}

