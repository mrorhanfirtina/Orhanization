using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants.StockMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Create;

public class CreateStockMemoCommand : IRequest<CreatedStockMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockMemos";

    public CreateStockMemoDto StockMemo { get; set; }


    public class CreateStockMemoCommandHandler : IRequestHandler<CreateStockMemoCommand, CreatedStockMemoResponse>
    {
        private readonly IStockMemoRepository _stockMemoRepository;
        private readonly StockMemoBusinessRules _stockMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockMemoCommandHandler(IStockMemoRepository stockMemoRepository, IMapper mapper, StockMemoBusinessRules stockMemoBusinessRules)
        {
            _stockMemoRepository = stockMemoRepository;
            _mapper = mapper;
            _stockMemoBusinessRules = stockMemoBusinessRules;
        }

        public async Task<CreatedStockMemoResponse> Handle(CreateStockMemoCommand request, CancellationToken cancellationToken)
        {
            _stockMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckStockIdExistence(request.StockMemo.StockId);

            StockMemo stockMemo = _mapper.Map<StockMemo>(request.StockMemo);
            stockMemo.Id = Guid.NewGuid();
            stockMemo.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockMemoResponse>(await _stockMemoRepository.AddAsync(stockMemo));
        }
    }
}
