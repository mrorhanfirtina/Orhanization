using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetList;

public class GetListWorkTaskQuery : IRequest<GetListResponse<GetListWorkTaskListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListWorkTaskQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetWorkTasks";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListWorkTaskQueryHandler : IRequestHandler<GetListWorkTaskQuery, GetListResponse<GetListWorkTaskListItemDto>>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetListWorkTaskQueryHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<GetListResponse<GetListWorkTaskListItemDto>> Handle(GetListWorkTaskQuery request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<WorkTask> workTaskList = await _workTaskRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListWorkTaskListItemDto>>(workTaskList);
        }
    }

}

