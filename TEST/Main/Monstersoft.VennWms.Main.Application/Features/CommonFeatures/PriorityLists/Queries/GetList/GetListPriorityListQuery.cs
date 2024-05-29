using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants.PriorityListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetList;

public class GetListPriorityListQuery : IRequest<GetListResponse<GetListPriorityListListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string CacheKey => $"GetListPriorityListQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetPriorityLists";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public PriorityListDetailLevel DetailLevel { get; set; }

    public class GetListPriorityListQueryHandler : IRequestHandler<GetListPriorityListQuery, GetListResponse<GetListPriorityListListItemDto>>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;
        private readonly IMapper _mapper;

        public GetListPriorityListQueryHandler(IPriorityListRepository priorityListRepository, IMapper mapper, PriorityListBusinessRules priorityListBusinessRules)
        {
            _priorityListRepository = priorityListRepository;
            _mapper = mapper;
            _priorityListBusinessRules = priorityListBusinessRules;
        }

        public async Task<GetListResponse<GetListPriorityListListItemDto>> Handle(GetListPriorityListQuery request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PriorityList> priorityListList = await _priorityListRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<PriorityList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<PriorityList, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPriorityListListItemDto>>(priorityListList);
            }
            else
            {
                Paginate<PriorityList> priorityListList = await _priorityListRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPriorityListListItemDto>>(priorityListList);
            }
        }
    }
}



