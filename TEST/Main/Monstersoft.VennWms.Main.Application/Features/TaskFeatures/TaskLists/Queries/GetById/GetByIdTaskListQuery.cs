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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetById;

public class GetByIdTaskListQuery : IRequest<GetByIdTaskListResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdTaskListQueryHandler : IRequestHandler<GetByIdTaskListQuery, GetByIdTaskListResponse>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly TaskListBusinessRules _taskListBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTaskListQueryHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _mapper = mapper;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<GetByIdTaskListResponse> Handle(GetByIdTaskListQuery request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdTaskListResponse>(await _taskListRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.WorkTasks),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

