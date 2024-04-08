using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants.StockReserveReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Update;

public class UpdateStockReserveReasonCommand : IRequest<UpdatedStockReserveReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockReserveReasonOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockReserveReasons";

    public UpdateStockReserveReasonDto StockReserveReason { get; set; }


    public class UpdateStockReserveReasonCommandHandler : IRequestHandler<UpdateStockReserveReasonCommand, UpdatedStockReserveReasonResponse>
    {
        private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
        private readonly StockReserveReasonBusinessRules _stockReserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockReserveReasonCommandHandler(IStockReserveReasonRepository stockReserveReasonRepository, StockReserveReasonBusinessRules stockReserveReasonBusinessRules, IMapper mapper)
        {
            _stockReserveReasonRepository = stockReserveReasonRepository;
            _stockReserveReasonBusinessRules = stockReserveReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockReserveReasonResponse> Handle(UpdateStockReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _stockReserveReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockReserveReason.Id)
            .CheckStockIdExistence(request.StockReserveReason.StockId)
            .CheckReserveReasonIdExistence(request.StockReserveReason.ReserveReasonId);

            StockReserveReason? currentStockReserveReason = await _stockReserveReasonRepository.GetAsync(predicate: x => x.Id == request.StockReserveReason.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockReserveReason? stockReserveReason = _mapper.Map(request.StockReserveReason, currentStockReserveReason);
            stockReserveReason.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockReserveReasonResponse>(await _stockReserveReasonRepository.UpdateAsync(stockReserveReason));
        }
    }
}

