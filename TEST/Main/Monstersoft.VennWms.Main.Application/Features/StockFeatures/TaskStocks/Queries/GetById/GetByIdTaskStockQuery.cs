using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants.TaskStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Queries.GetById;

public class GetByIdTaskStockQuery : IRequest<GetByIdTaskStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public TaskStocksDetailLevel? DetailLevel { get; set; }


    public class GetByIdTaskStockQueryHandler : IRequestHandler<GetByIdTaskStockQuery, GetByIdTaskStockResponse>
    {
        private readonly ITaskStockRepository _taskStockRepository;
        private readonly TaskStockBusinessRules _taskStockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTaskStockQueryHandler(ITaskStockRepository taskStockRepository, IMapper mapper, TaskStockBusinessRules taskStockBusinessRules)
        {
            _taskStockRepository = taskStockRepository;
            _mapper = mapper;
            _taskStockBusinessRules = taskStockBusinessRules;
        }

        public async Task<GetByIdTaskStockResponse> Handle(GetByIdTaskStockQuery request, CancellationToken cancellationToken)
        {
            _taskStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdTaskStockResponse>(await _taskStockRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<TaskStock> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeWorkTask)
                    {
                        query = query.Include(y => y.WorkTask);
                    }

                    var includableQuery = query as IIncludableQueryable<TaskStock, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdTaskStockResponse>(await _taskStockRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
