using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants.LocationProductConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductConstraintQuery : IRequest<GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationProductConstraintsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationProductConstraintQueryHandler : IRequestHandler<GetListByDynamicLocationProductConstraintQuery, GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>>
    {
        private readonly ILocationProductConstraintRepository _locationProductConstraintRepository;
        private readonly LocationProductConstraintBusinessRules _locationProductConstraintBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationProductConstraintQueryHandler(ILocationProductConstraintRepository locationProductConstraintRepository, IMapper mapper, LocationProductConstraintBusinessRules locationProductConstraintBusinessRules)
        {
            _locationProductConstraintRepository = locationProductConstraintRepository;
            _locationProductConstraintBusinessRules = locationProductConstraintBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>> Handle(GetListByDynamicLocationProductConstraintQuery request, CancellationToken cancellationToken)
        {
            _locationProductConstraintBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationProductConstraint> locationProductConstraintList = await _locationProductConstraintRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<LocationProductConstraint> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProductConstraint, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>>(locationProductConstraintList);
            }
            else
            {
                Paginate<LocationProductConstraint> locationProductConstraintList = await _locationProductConstraintRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationProductConstraintListItemDto>>(locationProductConstraintList);
            }
        }
    }
}

