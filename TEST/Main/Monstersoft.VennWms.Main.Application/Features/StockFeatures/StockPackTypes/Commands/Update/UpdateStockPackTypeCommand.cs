using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;

public class UpdateStockPackTypeCommand : IRequest<UpdatedStockPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockPackTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockPackTypes";

    public UpdateStockPackTypeDto StockPackType { get; set; }


    public class UpdateStockPackTypeCommandHandler : IRequestHandler<UpdateStockPackTypeCommand, UpdatedStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockPackTypeCommandHandler(IStockPackTypeRepository stockPackTypeRepository, StockPackTypeBusinessRules stockPackTypeBusinessRules, IMapper mapper)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockPackTypeResponse> Handle(UpdateStockPackTypeCommand request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockPackType.Id)
            .CheckItemUnitIdExistence(request.StockPackType.ItemUnitId)
            .CheckStockIdExistence(request.StockPackType.StockId);

            StockPackType? currentStockPackType = await _stockPackTypeRepository.GetAsync(predicate: x => x.Id == request.StockPackType.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockPackType? stockPackType = _mapper.Map(request.StockPackType, currentStockPackType);
            stockPackType.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockPackTypeResponse>(await _stockPackTypeRepository.UpdateAsync(stockPackType));
        }
    }
}

