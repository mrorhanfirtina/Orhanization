using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetListByDynamic;

public class GetListByDynamicWorkTaskQuery : IRequest<GetListResponse<GetListByDynamicWorkTaskListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicWorkTaskQueryHandler : IRequestHandler<GetListByDynamicWorkTaskQuery, GetListResponse<GetListByDynamicWorkTaskListItemDto>>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicWorkTaskQueryHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _workTaskBusinessRules = workTaskBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicWorkTaskListItemDto>> Handle(GetListByDynamicWorkTaskQuery request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<WorkTask> workTaskList = await _workTaskRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicWorkTaskListItemDto>>(workTaskList);
        }
    }
}

