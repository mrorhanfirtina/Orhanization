using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.DtoProfiles;

public class ProductStockAttributeDtoMappingProfiles : Profile
{
    public ProductStockAttributeDtoMappingProfiles()
    {
        CreateMap<ProductStockAttribute, CreateProductStockAttributeDto>().ReverseMap();
        CreateMap<ProductStockAttribute, CreateProductStockAttributeSubDto>().ReverseMap();
        CreateMap<ProductStockAttribute, UpdateProductStockAttributeDto>().ReverseMap();
        CreateMap<ProductStockAttribute, UpdateProductStockAttributeSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ProductStockAttributeAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Product, ProductStockAttributeProductResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ProductStockAttributeStockAttributeResponseDto>().ReverseMap();
    }
}
