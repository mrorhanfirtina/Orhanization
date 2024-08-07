﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
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
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetListByDynamic;

public class GetListByDynamicShipmentAttributeQuery : IRequest<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ShipmentAttributesDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicShipmentAttributeQueryHandler : IRequestHandler<GetListByDynamicShipmentAttributeQuery, GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicShipmentAttributeQueryHandler(IShipmentAttributeRepository shipmentAttributeRepository, IMapper mapper, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>> Handle(GetListByDynamicShipmentAttributeQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ShipmentAttribute> shipmentAttributeList = await _shipmentAttributeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<ShipmentAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    var includableQuery = query as IIncludableQueryable<ShipmentAttribute, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>(shipmentAttributeList);
            }
            else
            {
                Paginate<ShipmentAttribute> shipmentAttributeList = await _shipmentAttributeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>(shipmentAttributeList);
            }
        }
    }
}
