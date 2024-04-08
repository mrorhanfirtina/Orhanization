using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Delete;

public class DeleteStockCommand : IRequest<DeletedStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStocks";

    public Guid Id { get; set; }


    public class DeleteStockCommandHandler : IRequestHandler<DeleteStockCommand, DeletedStockResponse>
    {
        private readonly IStockRepository _stockRepository;
        private readonly StockBusinessRules _stockBusinessRules;

        public DeleteStockCommandHandler(IStockRepository stockRepository, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<DeletedStockResponse> Handle(DeleteStockCommand request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Stock stock = await _stockRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockRepository.DeleteAsync(stock);

            return new DeletedStockResponse
            {
                Id = stock.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = stock.DepositorId,
                IsSuccess = true,
                Message = StockMessages.RequestExecutedSuccessfully
            };
        }
    }
}

