using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Create;

public class CreateStockCommand : IRequest<CreatedStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStocks";

    public CreateStockDto Stock { get; set; }


    public class CreateStockCommandHandler : IRequestHandler<CreateStockCommand, CreatedStockResponse>
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;
        private readonly StockBusinessRules _stockBusinessRules;

        public CreateStockCommandHandler(IStockRepository stockRepository, IMapper mapper, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<CreatedStockResponse> Handle(CreateStockCommand request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckDepositorIdExistence(request.Stock.DepositorId);

            Stock? stock = _mapper.Map<Stock>(request.Stock);

            stock.CreatedDate = DateTime.Now;
            stock.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            stock.StockMemos?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            stock.StockAttributeValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            stock.StockReserveReasons?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            stock.StockUnsuitReasons?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            stock.StockInbounds?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            stock.StockPackTypes?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            return _mapper.Map<CreatedStockResponse>(await _stockRepository.AddAsync(stock));
        }
    }
}

