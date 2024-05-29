using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants.LocationProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductAbcCategoryQuery : IRequest<GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationProductAbcCategoryDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationProductAbcCategoryQueryHandler : IRequestHandler<GetListByDynamicLocationProductAbcCategoryQuery, GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>>
    {
        private readonly ILocationProductAbcCategoryRepository _locationProductAbcCategoryRepository;
        private readonly LocationProductAbcCategoryBusinessRules _locationProductAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationProductAbcCategoryQueryHandler(ILocationProductAbcCategoryRepository locationProductAbcCategoryRepository, IMapper mapper, LocationProductAbcCategoryBusinessRules locationProductAbcCategoryBusinessRules)
        {
            _locationProductAbcCategoryRepository = locationProductAbcCategoryRepository;
            _locationProductAbcCategoryBusinessRules = locationProductAbcCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>> Handle(GetListByDynamicLocationProductAbcCategoryQuery request, CancellationToken cancellationToken)
        {
            _locationProductAbcCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationProductAbcCategory> locationProductAbcCategoryList = await _locationProductAbcCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<LocationProductAbcCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeAbcCategory)
                    {
                        query = query.Include(y => y.AbcCategory);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationProductAbcCategory, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>>(locationProductAbcCategoryList);
            }
            else
            {
                Paginate<LocationProductAbcCategory> locationProductAbcCategoryList = await _locationProductAbcCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductAbcCategoryListItemDto>>(locationProductAbcCategoryList);
            }
        }
    }
}

