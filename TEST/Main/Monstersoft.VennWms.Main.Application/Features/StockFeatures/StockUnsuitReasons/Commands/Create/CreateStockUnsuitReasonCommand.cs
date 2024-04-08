using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants.StockUnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Create;

public class CreateStockUnsuitReasonCommand : IRequest<CreatedStockUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockUnsuitReasons";

    public CreateStockUnsuitReasonDto StockUnsuitReason { get; set; }


    public class CreateStockUnsuitReasonCommandHandler : IRequestHandler<CreateStockUnsuitReasonCommand, CreatedStockUnsuitReasonResponse>
    {
        private readonly IStockUnsuitReasonRepository _stockUnsuitReasonRepository;
        private readonly StockUnsuitReasonBusinessRules _stockUnsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockUnsuitReasonCommandHandler(IStockUnsuitReasonRepository stockUnsuitReasonRepository, IMapper mapper, StockUnsuitReasonBusinessRules stockUnsuitReasonBusinessRules)
        {
            _stockUnsuitReasonRepository = stockUnsuitReasonRepository;
            _mapper = mapper;
            _stockUnsuitReasonBusinessRules = stockUnsuitReasonBusinessRules;
        }

        public async Task<CreatedStockUnsuitReasonResponse> Handle(CreateStockUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _stockUnsuitReasonBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckStockIdExistence(request.StockUnsuitReason.StockId)
                .CheckUnsuitReasonIdExistence(request.StockUnsuitReason.UnsuitReasonId);

            StockUnsuitReason stockUnsuitReason = _mapper.Map<StockUnsuitReason>(request.StockUnsuitReason);
            stockUnsuitReason.Id = Guid.NewGuid();
            stockUnsuitReason.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockUnsuitReasonResponse>(await _stockUnsuitReasonRepository.AddAsync(stockUnsuitReason));
        }
    }
}
