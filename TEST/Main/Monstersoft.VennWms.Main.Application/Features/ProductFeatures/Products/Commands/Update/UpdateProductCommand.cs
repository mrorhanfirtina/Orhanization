using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.UpdateDtos;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants.ProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Update;

public class UpdateProductCommand : IRequest<UpdatedProductResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ProductOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProducts";

    public UpdateProductDto Product { get; set; }
    public ProductDetailLevel DetailLevel { get; set; }



    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdatedProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ProductBusinessRules _productBusinessRules;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<UpdatedProductResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            _productBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Product.Id);

            Product? currentProduct = await _productRepository.GetAsync(predicate: x => x.Id == request.Product.Id,
            include: x => x.Include(y => y.ProductAbcCategory)
                           .Include(y => y.ProductCategory)
                           .Include(y => y.ProductAttributeValues)
                           .Include(y => y.ProductBarcodes)
                           .Include(y => y.ProductDepositors)
                           .Include(y => y.ProductStockAttributes)
                           .Include(y => y.ItemUnits)
                           .Include(y => y.ItemUnits).ThenInclude(z => z.ItemPackTypes),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Product? product = _mapper.Map(request.Product, currentProduct);
            product.UpdatedDate = DateTime.Now;

            currentProduct.UpdatedDate = DateTime.Now;

            if (currentProduct.ProductAbcCategory != null)
            {
                currentProduct.ProductAbcCategory.CreatedDate = currentProduct.CreatedDate;
                currentProduct.ProductAbcCategory.UpdatedDate = DateTime.Now;
            }

            if (currentProduct.ProductCategory != null)
            {
                currentProduct.ProductCategory.CreatedDate = currentProduct.CreatedDate;
                currentProduct.ProductCategory.UpdatedDate = DateTime.Now;
            }
                
            currentProduct.ItemUnits?.ToList().ForEach(x =>
            {
                x.CreatedDate = currentProduct.CreatedDate;
                x.UpdatedDate = DateTime.Now;

                x.ItemPackTypes?.ToList().ForEach(y => { y.CreatedDate = currentProduct.CreatedDate; y.UpdatedDate = DateTime.Now; });

                x.ItemUnitConversions?.ToList().ForEach(y => { y.CreatedDate = currentProduct.CreatedDate; y.UpdatedDate = DateTime.Now; });
            });

            currentProduct.ProductAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = currentProduct.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            currentProduct.ProductDepositors?.ToList().ForEach(x =>
            {
                x.CreatedDate = currentProduct.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            currentProduct.ProductBarcodes?.ToList().ForEach(x =>
            {
                x.CreatedDate = currentProduct.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            currentProduct.ProductStockAttributes?.ToList().ForEach(x =>
            {
                x.CreatedDate = currentProduct.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            await _productRepository.UpdateAsync(currentProduct);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productRepository.GetAsync(predicate: x => x.Id == product.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductResponse>(response);
            }
            else
            {
                var response = await _productRepository.GetAsync(predicate: x => x.Id == product.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductResponse>(response);
            }
        }
    }
}
