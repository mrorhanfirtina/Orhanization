using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Create;

public class CreateStockPackTypeCommand : IRequest<CreatedStockPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockPackTypes";

    public CreateStockPackTypeDto StockPackType { get; set; }


    public class CreateStockPackTypeCommandHandler : IRequestHandler<CreateStockPackTypeCommand, CreatedStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockPackTypeCommandHandler(IStockPackTypeRepository stockPackTypeRepository, IMapper mapper, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _mapper = mapper;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
        }

        public async Task<CreatedStockPackTypeResponse> Handle(CreateStockPackTypeCommand request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckItemUnitIdExistence(request.StockPackType.ItemUnitId)
                .CheckStockIdExistence(request.StockPackType.StockId);

            StockPackType stockPackType = _mapper.Map<StockPackType>(request.StockPackType);
            stockPackType.Id = Guid.NewGuid();
            stockPackType.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockPackTypeResponse>(await _stockPackTypeRepository.AddAsync(stockPackType));
        }
    }
}

