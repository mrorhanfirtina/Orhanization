using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;

public class UpdateStockUnsuitReasonCommand : IRequest<UpdatedStockUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockUnsuitReasonOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockUnsuitReasons";

    public UpdateStockUnsuitReasonDto StockUnsuitReason { get; set; }


    public class UpdateStockUnsuitReasonCommandHandler : IRequestHandler<UpdateStockUnsuitReasonCommand, UpdatedStockUnsuitReasonResponse>
    {
        private readonly IStockUnsuitReasonRepository _stockUnsuitReasonRepository;
        private readonly StockUnsuitReasonBusinessRules _stockUnsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockUnsuitReasonCommandHandler(IStockUnsuitReasonRepository stockUnsuitReasonRepository, StockUnsuitReasonBusinessRules stockUnsuitReasonBusinessRules, IMapper mapper)
        {
            _stockUnsuitReasonRepository = stockUnsuitReasonRepository;
            _stockUnsuitReasonBusinessRules = stockUnsuitReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockUnsuitReasonResponse> Handle(UpdateStockUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _stockUnsuitReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockUnsuitReason.Id)
            .CheckUnsuitReasonIdExistence(request.StockUnsuitReason.UnsuitReasonId)
            .CheckStockIdExistence(request.StockUnsuitReason.StockId);

            StockUnsuitReason? currentStockUnsuitReason = await _stockUnsuitReasonRepository.GetAsync(predicate: x => x.Id == request.StockUnsuitReason.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockUnsuitReason? stockUnsuitReason = _mapper.Map(request.StockUnsuitReason, currentStockUnsuitReason);
            stockUnsuitReason.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockUnsuitReasonResponse>(await _stockUnsuitReasonRepository.UpdateAsync(stockUnsuitReason));
        }
    }
}
