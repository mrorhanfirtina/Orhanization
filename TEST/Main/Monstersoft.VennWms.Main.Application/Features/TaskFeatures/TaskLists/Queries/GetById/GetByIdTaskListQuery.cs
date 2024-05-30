using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
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
    public TaskListsDetailLevel? DetailLevel { get; set; }


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

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdTaskListResponse>(await _taskListRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<TaskList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeWorkTask)
                    {
                        query = query.Include(y => y.WorkTasks);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        var depositorDetailLevel = detailLevel.DepositorDetailLevel;

                        if (depositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(y => y.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<TaskList, object>;
                    return includableQuery;
                },
                withDeleted: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdTaskListResponse>(await _taskListRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, cancellationToken: cancellationToken));
            }
        }
    }

}

