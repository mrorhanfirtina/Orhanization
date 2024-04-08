using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Create;

public class CreateStockContainerCommand : IRequest<CreatedStockContainerResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockContainers";

    public CreateStockContainerDto StockContainer { get; set; }


    public class CreateStockContainerCommandHandler : IRequestHandler<CreateStockContainerCommand, CreatedStockContainerResponse>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockContainerCommandHandler(IStockContainerRepository stockContainerRepository, IMapper mapper, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _mapper = mapper;
            _stockContainerBusinessRules = stockContainerBusinessRules;
        }

        public async Task<CreatedStockContainerResponse> Handle(CreateStockContainerCommand request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckContainerUnitIdExistence(request.StockContainer.ContainerUnitId);

            StockContainer stockContainer = _mapper.Map<StockContainer>(request.StockContainer);
            stockContainer.Id = Guid.NewGuid();
            stockContainer.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockContainerResponse>(await _stockContainerRepository.AddAsync(stockContainer));
        }
    }
}
