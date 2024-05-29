using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants.ProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetList;

public class GetListProductQuery : IRequest<GetListResponse<GetListProductListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListProductQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetProducts";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ProductDetailLevel DetailLevel { get; set; }



    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, GetListResponse<GetListProductListItemDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductBusinessRules _productBusinessRules;
        private readonly IMapper _mapper;

        public GetListProductQueryHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<GetListResponse<GetListProductListItemDto>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
        {
            _productBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Product> productList = await _productRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Product> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeProductStockAttribute)
                    {
                        query = query.Include(y => y.ProductStockAttributes);

                        if (detailLevel.ProductStockAttributeDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.ProductStockAttributes).ThenInclude(y => y.StockAttribute);

                            if (detailLevel.ProductStockAttributeDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ProductStockAttributes).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeProductDepositor)
                    {
                        query = query.Include(y => y.ProductDepositors);

                        if (detailLevel.ProductDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.ProductDepositors).ThenInclude(y => y.Depositor);

                            if (detailLevel.ProductDepositorDetailLevel.DepositorDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.ProductDepositors).ThenInclude(y => y.Depositor).ThenInclude(y => y.Company);
                            }
                        }
                    }

                    if (detailLevel.IncludeProductBarcode)
                    {
                        query = query.Include(y => y.ProductBarcodes);

                        if (detailLevel.ProductBarcodeDetailLevel.IncludeBarcodeSupplier)
                        {
                            query = query.Include(y => y.ProductBarcodes).ThenInclude(y => y.BarcodeSuppliers);

                            if (detailLevel.ProductBarcodeDetailLevel.BarcodeSupplierDetailLevel.IncludeSupplier)
                            {
                                query = query.Include(y => y.ProductBarcodes).ThenInclude(y => y.BarcodeSuppliers).ThenInclude(y => y.Supplier);
                            }
                        }
                    }

                    if (detailLevel.IncludeProductAttributeValue)
                    {
                        query = query.Include(y => y.ProductAttributeValues);

                        if (detailLevel.ProductAttributeValueDetailLevel.IncludeProductAttribute)
                        {
                            query = query.Include(y => y.ProductAttributeValues).ThenInclude(y => y.ProductAttribute);

                            if (detailLevel.ProductAttributeValueDetailLevel.ProductAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ProductAttributeValues).ThenInclude(y => y.ProductAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeProductCategory)
                    {
                        query = query.Include(y => y.ProductCategory);

                        if (detailLevel.ProductCategoryDetailLevel.IncludeCategory)
                        {
                            query = query.Include(y => y.ProductCategory).ThenInclude(y => y.Category);
                        }
                    }

                    if (detailLevel.IncludeProductAbcCategory)
                    {
                        query = query.Include(y => y.ProductAbcCategory);

                        if (detailLevel.ProductAbcCategoryDetailLevel.IncludeAbcCategoryList)
                        {
                            query = query.Include(y => y.ProductAbcCategory).ThenInclude(y => y.AbcCategory);
                        }
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnits);

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnits).ThenInclude(y => y.Unit);
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeItemPackType)
                        {
                            query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemPackTypes);

                            if (detailLevel.ItemUnitDetailLevel.ItemPackTypeDetailLevel.IncludeLenghtUnit)
                            {
                                query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.LenghtUnit);
                            }

                            if (detailLevel.ItemUnitDetailLevel.ItemPackTypeDetailLevel.IncludeVolumeUnit)
                            {
                                query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.VolumeUnit);
                            }

                            if (detailLevel.ItemUnitDetailLevel.ItemPackTypeDetailLevel.IncludeWeightUnit)
                            {
                                query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemPackTypes).ThenInclude(y => y.WeightUnit);
                            }
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeItemUnitConversion)
                        {
                            query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemUnitConversions);

                            if (detailLevel.ItemUnitDetailLevel.ItemUnitConversionDetailLevel.IncludeConvertedItemUnit)
                            {
                                query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit);

                                if (detailLevel.ItemUnitDetailLevel.ItemUnitConversionDetailLevel.ConvertedItemUnitDetailLevel.IncludeUnit)
                                {
                                    query = query.Include(y => y.ItemUnits).ThenInclude(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit).ThenInclude(y => y.Unit);
                                }
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Product, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListProductListItemDto>>(productList);
            }
            else
            {
                Paginate<Product> productList = await _productRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListProductListItemDto>>(productList);
            }
        }
    }

}
