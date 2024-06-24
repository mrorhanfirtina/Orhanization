using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants.LocationProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductCategoryQuery : IRequest<GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationProductCategoriesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationProductCategoryQueryHandler : IRequestHandler<GetListByDynamicLocationProductCategoryQuery, GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>>
    {
        private readonly ILocationProductCategoryRepository _locationProductCategoryRepository;
        private readonly LocationProductCategoryBusinessRules _locationProductCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationProductCategoryQueryHandler(ILocationProductCategoryRepository locationProductCategoryRepository, IMapper mapper, LocationProductCategoryBusinessRules locationProductCategoryBusinessRules)
        {
            _locationProductCategoryRepository = locationProductCategoryRepository;
            _locationProductCategoryBusinessRules = locationProductCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>> Handle(GetListByDynamicLocationProductCategoryQuery request, CancellationToken cancellationToken)
        {
            _locationProductCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationProductCategory> locationProductCategoryList = await _locationProductCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<LocationProductCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeCategory)
                    {
                        query = query.Include(y => y.Category);
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProductCategory, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>>(locationProductCategoryList);
            }
            else
            {
                Paginate<LocationProductCategory> locationProductCategoryList = await _locationProductCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductCategoryListItemDto>>(locationProductCategoryList);
            }
        }
    }
}

