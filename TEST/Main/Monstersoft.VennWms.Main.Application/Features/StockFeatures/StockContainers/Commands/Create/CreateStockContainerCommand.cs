using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public StockContainersDetailLevel? DetailLevel { get; set; }


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

            await _stockContainerRepository.AddAsync(stockContainer);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _stockContainerRepository.GetAsync(predicate: x => x.Id == stockContainer.Id,
                include: x =>
                {
                    IQueryable<StockContainer> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeContainerUnit)
                    {
                        query = query.Include(y => y.ContainerUnit);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stocks);

                        var stockDetailLevel = detailLevel.StockDetailLevel;

                        if (stockDetailLevel.IncludeStockAttributeValue)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues);

                            var stockAttributeValueDetailLevel = stockDetailLevel.StockAttributeValueDetailLevel;

                            if (stockAttributeValueDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues).ThenInclude(y => y.StockAttribute);

                                var stockAttributeDetailLevel = stockAttributeValueDetailLevel.StockAttributeDetailLevel;

                                if (stockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.Stocks).ThenInclude(m => m.StockAttributeValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                                }
                            }
                        }

                        if (stockDetailLevel.IncludeStockMemo)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockMemos);
                        }

                        if (stockDetailLevel.IncludeStockReserveReason)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockReserveReasons);

                            var stockReserveReasonDetailLevel = stockDetailLevel.StockReserveReasonDetailLevel;

                            if (stockReserveReasonDetailLevel.IncludeReserveReason)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockReserveReasons).ThenInclude(y => y.ReserveReason);
                            }
                        }

                        if (stockDetailLevel.IncludeStockUnsuitReason)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.StockUnsuitReasons);

                            var stockUnsuitReasonDetailLevel = stockDetailLevel.StockUnsuitReasonDetailLevel;

                            if (stockUnsuitReasonDetailLevel.IncludeUnsuitReason)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.StockUnsuitReasons).ThenInclude(y => y.UnsuitReason);
                            }
                        }

                        if (stockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Product);
                        }

                        if (stockDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Depositor);

                            if (stockDetailLevel.DepositorDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.Depositor).ThenInclude(y => y.Company);
                            }
                        }

                        if (stockDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.DepositorCompany);
                        }

                        if (stockDetailLevel.IncludeLocation)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.Location);
                        }

                        if (stockDetailLevel.IncludeCuItemUnit)
                        {
                            query = query.Include(y => y.Stocks).ThenInclude(m => m.CuItemUnit);

                            var cuItemUnitDetailLevel = stockDetailLevel.CuItemUnitDetailLevel;

                            if (cuItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.Stocks).ThenInclude(m => m.CuItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockContainer, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockContainerResponse>(response);
            }
            else
            {
                var response = await _stockContainerRepository.GetAsync(predicate: x => x.Id == stockContainer.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockContainerResponse>(response);
            }
        }
    }
}
