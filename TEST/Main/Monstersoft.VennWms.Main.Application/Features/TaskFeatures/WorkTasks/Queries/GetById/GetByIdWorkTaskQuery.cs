using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetById;

public class GetByIdWorkTaskQuery : IRequest<GetByIdWorkTaskResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public WorkTasksDetailLevel? DetailLevel { get; set; }


    public class GetByIdWorkTaskQueryHandler : IRequestHandler<GetByIdWorkTaskQuery, GetByIdWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdWorkTaskQueryHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<GetByIdWorkTaskResponse> Handle(GetByIdWorkTaskQuery request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdWorkTaskResponse>(await _workTaskRepository.GetAsync(x => x.Id == request.Id,
                    include: x =>
                    {
                        IQueryable<WorkTask> query = x;

                        var detailLevel = request.DetailLevel;

                        if (detailLevel.IncludeFromLocation)
                        {
                            query = query.Include(y => y.FromLocation);
                        }

                        if (detailLevel.IncludeToLocation)
                        {
                            query = query.Include(y => y.ToLocation);
                        }

                        if (detailLevel.IncludeStatus)
                        {
                            query = query.Include(y => y.Status);
                        }

                        if (detailLevel.IncludeTransactionType)
                        {
                            query = query.Include(y => y.TransactionType);
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

                        if (detailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.DepositorCompany);
                        }

                        if (detailLevel.IncludeOrderShipItemTask)
                        {
                            query = query.Include(y => y.OrderShipItemTasks);
                        }

                        if (detailLevel.IncludeStock)
                        {
                            query = query.Include(y => y.Stock);

                            var stockDetailLevel = detailLevel.StockDetailLevel;

                            if (stockDetailLevel.IncludeProduct)
                            {
                                query = query.Include(y => y.Stock).ThenInclude(y => y.Product);
                            }
                        }

                        var includableQuery = query as IIncludableQueryable<WorkTask, object>;
                        return includableQuery;
                    },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdWorkTaskResponse>(await _workTaskRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

