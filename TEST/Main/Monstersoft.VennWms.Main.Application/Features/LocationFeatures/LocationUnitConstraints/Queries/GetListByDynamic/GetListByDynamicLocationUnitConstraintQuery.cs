using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants.LocationUnitConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Queries.GetListByDynamic;

public class GetListByDynamicLocationUnitConstraintQuery : IRequest<GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationUnitConstraintDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationUnitConstraintQueryHandler : IRequestHandler<GetListByDynamicLocationUnitConstraintQuery, GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>>
    {
        private readonly ILocationUnitConstraintRepository _locationUnitConstraintRepository;
        private readonly LocationUnitConstraintBusinessRules _locationUnitConstraintBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationUnitConstraintQueryHandler(ILocationUnitConstraintRepository locationUnitConstraintRepository, IMapper mapper, LocationUnitConstraintBusinessRules locationUnitConstraintBusinessRules)
        {
            _locationUnitConstraintRepository = locationUnitConstraintRepository;
            _locationUnitConstraintBusinessRules = locationUnitConstraintBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>> Handle(GetListByDynamicLocationUnitConstraintQuery request, CancellationToken cancellationToken)
        {
            _locationUnitConstraintBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationUnitConstraint> locationUnitConstraintList = await _locationUnitConstraintRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<LocationUnitConstraint> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeUnit)
                    {
                        query = query.Include(y => y.Unit);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationUnitConstraint, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>>(locationUnitConstraintList);
            }
            else
            {
                Paginate<LocationUnitConstraint> locationUnitConstraintList = await _locationUnitConstraintRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationUnitConstraintListItemDto>>(locationUnitConstraintList);
            }
        }
    }
}

