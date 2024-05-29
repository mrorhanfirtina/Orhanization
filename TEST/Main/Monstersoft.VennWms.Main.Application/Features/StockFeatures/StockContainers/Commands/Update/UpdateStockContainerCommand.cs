using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Update;

public class UpdateStockContainerCommand : IRequest<UpdatedStockContainerResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockContainerOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockContainers";

    public UpdateStockContainerDto StockContainer { get; set; }


    public class UpdateStockContainerCommandHandler : IRequestHandler<UpdateStockContainerCommand, UpdatedStockContainerResponse>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockContainerCommandHandler(IStockContainerRepository stockContainerRepository, StockContainerBusinessRules stockContainerBusinessRules, IMapper mapper)
        {
            _stockContainerRepository = stockContainerRepository;
            _stockContainerBusinessRules = stockContainerBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockContainerResponse> Handle(UpdateStockContainerCommand request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockContainer.Id)
            .CheckContainerUnitIdExistence(request.StockContainer.ContainerUnitId);

            StockContainer? currentStockContainer = await _stockContainerRepository.GetAsync(predicate: x => x.Id == request.StockContainer.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockContainer? stockContainer = _mapper.Map(request.StockContainer, currentStockContainer);
            stockContainer.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockContainerResponse>(await _stockContainerRepository.UpdateAsync(stockContainer));
        }
    }
}
