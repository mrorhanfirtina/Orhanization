using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants.TaskListOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetList;

public class GetListTaskListQuery : IRequest<GetListResponse<GetListTaskListListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListTaskListQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetTaskLists";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListTaskListQueryHandler : IRequestHandler<GetListTaskListQuery, GetListResponse<GetListTaskListListItemDto>>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly TaskListBusinessRules _taskListBusinessRules;
        private readonly IMapper _mapper;

        public GetListTaskListQueryHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _mapper = mapper;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<GetListResponse<GetListTaskListListItemDto>> Handle(GetListTaskListQuery request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TaskList> taskListList = await _taskListRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.WorkTasks),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListTaskListListItemDto>>(taskListList);
        }
    }

}

