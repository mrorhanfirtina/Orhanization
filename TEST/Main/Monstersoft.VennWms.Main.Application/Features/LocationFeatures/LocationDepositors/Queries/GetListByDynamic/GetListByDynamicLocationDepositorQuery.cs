using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants.LocationDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Queries.GetListByDynamic;

public class GetListByDynamicLocationDepositorQuery : IRequest<GetListResponse<GetListByDynamicLocationDepositorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationDepositorDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationDepositorQueryHandler : IRequestHandler<GetListByDynamicLocationDepositorQuery, GetListResponse<GetListByDynamicLocationDepositorListItemDto>>
    {
        private readonly ILocationDepositorRepository _locationDepositorRepository;
        private readonly LocationDepositorBusinessRules _locationDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationDepositorQueryHandler(ILocationDepositorRepository locationDepositorRepository, IMapper mapper, LocationDepositorBusinessRules locationDepositorBusinessRules)
        {
            _locationDepositorRepository = locationDepositorRepository;
            _locationDepositorBusinessRules = locationDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationDepositorListItemDto>> Handle(GetListByDynamicLocationDepositorQuery request, CancellationToken cancellationToken)
        {
            _locationDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationDepositor> locationDepositorList = await _locationDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<LocationDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    var includableQuery = query as IIncludableQueryable<LocationDepositor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationDepositorListItemDto>>(locationDepositorList);
            }
            else
            {
                Paginate<LocationDepositor> locationDepositorList = await _locationDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationDepositorListItemDto>>(locationDepositorList);
            }
        }
    }
}

