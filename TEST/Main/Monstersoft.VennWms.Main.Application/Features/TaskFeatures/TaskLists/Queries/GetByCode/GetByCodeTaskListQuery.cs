using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants.TaskListOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetByCode;

public class GetByCodeTaskListQuery : IRequest<GetByCodeTaskListResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeTaskListQueryHandler : IRequestHandler<GetByCodeTaskListQuery, GetByCodeTaskListResponse>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly TaskListBusinessRules _taskListBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeTaskListQueryHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _mapper = mapper;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<GetByCodeTaskListResponse> Handle(GetByCodeTaskListQuery request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeTaskListResponse>(await _taskListRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.WorkTasks),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

