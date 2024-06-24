﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetById;

public class GetByIdStockQuery : IRequest<GetByIdStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public StocksDetailLevel? DetailLevel { get; set; }


    public class GetByIdStockQueryHandler : IRequestHandler<GetByIdStockQuery, GetByIdStockResponse>
    {
        private readonly IStockRepository _stockRepository;
        private readonly StockBusinessRules _stockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockQueryHandler(IStockRepository stockRepository, IMapper mapper, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<GetByIdStockResponse> Handle(GetByIdStockQuery request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdStockResponse>(await _stockRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<Stock> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStockAttributeValue)
                    {
                        query = query.Include(y => y.StockAttributeValues);

                        var attributeValueDetailLevel = detailLevel.StockAttributeValueDetailLevel;

                        if (attributeValueDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.StockAttributeValues).ThenInclude(y => y.StockAttribute);

                            var attributeDetailLevel = attributeValueDetailLevel.StockAttributeDetailLevel;

                            if (attributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.StockAttributeValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeStockMemo)
                    {
                        query = query.Include(y => y.StockMemos);
                    }

                    if (detailLevel.IncludeStockReserveReason)
                    {
                        query = query.Include(y => y.StockReserveReasons);
                    }

                    if (detailLevel.IncludeStockUnsuitReason)
                    {
                        query = query.Include(y => y.StockUnsuitReasons);
                    }

                    if (detailLevel.IncludeStockInbound)
                    {
                        query = query.Include(y => y.StockInbounds);

                        var inboundDetailLevel = detailLevel.StockInboundDetailLevel;

                        if (inboundDetailLevel.IncludeReceipt)
                        {
                            query = query.Include(y => y.StockInbounds).ThenInclude(y => y.Receipt);
                        }

                        if (inboundDetailLevel.IncludeReturn)
                        {
                            query = query.Include(y => y.StockInbounds).ThenInclude(y => y.Return);
                        }
                    }

                    if (detailLevel.IncludeStockPackType)
                    {
                        query = query.Include(y => y.StockPackTypes);

                        var packTypeDetailLevel = detailLevel.StockPackTypeDetailLevel;

                        if (packTypeDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.StockPackTypes).ThenInclude(y => y.ItemUnit);

                            var itemUnitDetailLevel = packTypeDetailLevel.ItemUnitDetailLevel;

                            if (itemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.StockPackTypes).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);

                        var productDetailLevel = detailLevel.ProductDetailLevel;

                        if (productDetailLevel.IncludeProductBarcode)
                        {
                            query = query.Include(y => y.Product).ThenInclude(y => y.ProductBarcodes);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        var depositorDetailLevel = detailLevel.DepositorDetailLevel;

                        if (depositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(y => y.Company);
                        }
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeCuItemUnit)
                    {
                        query = query.Include(y => y.CuItemUnit);

                        var cuItemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (cuItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.Unit);

                            if (cuItemUnitDetailLevel.IncludeItemPackType)
                            {
                                query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes);

                                var itemPackTypeDetailLevel = cuItemUnitDetailLevel.ItemPackTypeDetailLevel;

                                if (itemPackTypeDetailLevel.IncludeLenghtUnit)
                                {
                                    query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.LenghtUnit);
                                }

                                if (itemPackTypeDetailLevel.IncludeVolumeUnit)
                                {
                                    query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.VolumeUnit);
                                }

                                if (itemPackTypeDetailLevel.IncludeWeightUnit)
                                {
                                    query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.WeightUnit);
                                }

                                if (itemPackTypeDetailLevel.IncludeItemUnit)
                                {
                                    query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.ItemUnit);

                                    var cuItemUnitPackTypeDetailLevel = itemPackTypeDetailLevel.CuItemUnitDetailLevel;

                                    if (cuItemUnitPackTypeDetailLevel.IncludeUnit)
                                    {
                                        query = query.Include(y => y.CuItemUnit).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                                    }
                                }
                            }
                        }
                    }

                    if (detailLevel.IncludeStockContainer)
                    {
                        query = query.Include(y => y.StockContainer);

                        var containerDetailLevel = detailLevel.StockContainerDetailLevel;

                        if (containerDetailLevel.IncludeContainerUnit)
                        {
                            query = query.Include(y => y.StockContainer).ThenInclude(y => y.ContainerUnit);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Stock, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdStockResponse>(await _stockRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

