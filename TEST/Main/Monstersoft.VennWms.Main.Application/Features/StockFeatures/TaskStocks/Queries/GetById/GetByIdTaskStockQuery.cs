using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
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

            return _mapper.Map<GetByIdTaskStockResponse>(await _taskStockRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
