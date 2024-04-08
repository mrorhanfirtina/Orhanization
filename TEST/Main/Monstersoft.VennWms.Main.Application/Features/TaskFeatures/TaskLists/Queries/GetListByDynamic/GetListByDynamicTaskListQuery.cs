using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants.TaskListOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetListByDynamic;

public class GetListByDynamicTaskListQuery : IRequest<GetListResponse<GetListByDynamicTaskListListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicTaskListQueryHandler : IRequestHandler<GetListByDynamicTaskListQuery, GetListResponse<GetListByDynamicTaskListListItemDto>>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly TaskListBusinessRules _taskListBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTaskListQueryHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _taskListBusinessRules = taskListBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTaskListListItemDto>> Handle(GetListByDynamicTaskListQuery request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TaskList> taskListList = await _taskListRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.WorkTasks),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicTaskListListItemDto>>(taskListList);
        }
    }
}

