using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Commands.Update;

public class UpdateStockCommand : IRequest<UpdatedStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStocks";

    public UpdateStockDto Stock { get; set; }


    public class UpdateStockCommandHandler : IRequestHandler<UpdateStockCommand, UpdatedStockResponse>
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;
        private readonly StockBusinessRules _stockBusinessRules;

        public UpdateStockCommandHandler(IStockRepository stockRepository, IMapper mapper, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<UpdatedStockResponse> Handle(UpdateStockCommand request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
            .CheckIdExistence(request.Stock.Id);

            Stock? currentStock = await _stockRepository.GetAsync(predicate: x => x.Id == request.Stock.Id,
            include: x => x.Include(y => y.StockMemos)
            .Include(y => y.StockAttributeValues)
            .Include(y => y.StockReserveReasons)
            .Include(y => y.StockInbounds)
            .Include(y => y.StockPackTypes)
            .Include(y => y.StockUnsuitReasons),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Stock? stock = _mapper.Map(request.Stock, currentStock);
            stock.UpdatedDate = DateTime.Now;

            stock.StockMemos?.ToList().ForEach(x => { x.CreatedDate = stock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            stock.StockUnsuitReasons?.ToList().ForEach(x => { x.CreatedDate = stock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            stock.StockReserveReasons?.ToList().ForEach(x => { x.CreatedDate = stock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            stock.StockAttributeValues?.ToList().ForEach(x => { x.CreatedDate = stock.CreatedDate; x.UpdatedDate = DateTime.Now; });
            stock.StockInbounds?.ToList().ForEach(x => { x.CreatedDate = stock.CreatedDate; x.UpdatedDate = DateTime.Now; });

            return _mapper.Map<UpdatedStockResponse>(await _stockRepository.UpdateAsync(stock));
        }
    }
}

