using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;

public class GetByIdStockContainerQuery : IRequest<GetByIdStockContainerResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public StockContainersDetailLevel? DetailLevel { get; set; }


    public class GetByIdStockContainerQueryHandler : IRequestHandler<GetByIdStockContainerQuery, GetByIdStockContainerResponse>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockContainerQueryHandler(IStockContainerRepository stockContainerRepository, IMapper mapper, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _mapper = mapper;
            _stockContainerBusinessRules = stockContainerBusinessRules;
        }

        public async Task<GetByIdStockContainerResponse> Handle(GetByIdStockContainerQuery request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdStockContainerResponse>(await _stockContainerRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdStockContainerResponse>(await _stockContainerRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
