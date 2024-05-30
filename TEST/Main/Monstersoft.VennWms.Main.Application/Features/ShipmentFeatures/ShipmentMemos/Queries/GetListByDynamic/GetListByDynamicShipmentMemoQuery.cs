using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants.ShipmentMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetListByDynamic;

public class GetListByDynamicShipmentMemoQuery : IRequest<GetListResponse<GetListByDynamicShipmentMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ShipmentMemosDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicShipmentMemoQueryHandler : IRequestHandler<GetListByDynamicShipmentMemoQuery, GetListResponse<GetListByDynamicShipmentMemoListItemDto>>
    {
        private readonly IShipmentMemoRepository _shipmentMemoRepository;
        private readonly ShipmentMemoBusinessRules _shipmentMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicShipmentMemoQueryHandler(IShipmentMemoRepository shipmentMemoRepository, IMapper mapper, ShipmentMemoBusinessRules shipmentMemoBusinessRules)
        {
            _shipmentMemoRepository = shipmentMemoRepository;
            _shipmentMemoBusinessRules = shipmentMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicShipmentMemoListItemDto>> Handle(GetListByDynamicShipmentMemoQuery request, CancellationToken cancellationToken)
        {
            _shipmentMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ShipmentMemo> shipmentMemoList = await _shipmentMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ShipmentMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeShipment)
                    {
                        query = query.Include(y => y.Shipment);
                    }

                    var includableQuery = query as IIncludableQueryable<ShipmentMemo, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentMemoListItemDto>>(shipmentMemoList);
            }
            else
            {
                Paginate<ShipmentMemo> shipmentMemoList = await _shipmentMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentMemoListItemDto>>(shipmentMemoList);
            }
        }
    }
}
