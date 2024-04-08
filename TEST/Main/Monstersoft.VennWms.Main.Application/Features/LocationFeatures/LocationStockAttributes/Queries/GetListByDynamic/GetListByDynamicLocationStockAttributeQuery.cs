﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants.LocationStockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetListByDynamic;

public class GetListByDynamicLocationStockAttributeQuery : IRequest<GetListResponse<GetListByDynamicLocationStockAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLocationStockAttributeQueryHandler : IRequestHandler<GetListByDynamicLocationStockAttributeQuery, GetListResponse<GetListByDynamicLocationStockAttributeListItemDto>>
    {
        private readonly ILocationStockAttributeRepository _locationStockAttributeRepository;
        private readonly LocationStockAttributeBusinessRules _locationStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationStockAttributeQueryHandler(ILocationStockAttributeRepository locationStockAttributeRepository, IMapper mapper, LocationStockAttributeBusinessRules locationStockAttributeBusinessRules)
        {
            _locationStockAttributeRepository = locationStockAttributeRepository;
            _locationStockAttributeBusinessRules = locationStockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationStockAttributeListItemDto>> Handle(GetListByDynamicLocationStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _locationStockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<LocationStockAttribute> locationStockAttributeList = await _locationStockAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLocationStockAttributeListItemDto>>(locationStockAttributeList);
        }
    }

}

