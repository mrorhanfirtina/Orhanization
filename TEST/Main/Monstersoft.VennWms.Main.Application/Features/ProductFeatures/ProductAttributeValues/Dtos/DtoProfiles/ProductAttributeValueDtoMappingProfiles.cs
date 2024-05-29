using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.DtoProfiles;

public class ProductAttributeValueDtoMappingProfiles : Profile
{
    public ProductAttributeValueDtoMappingProfiles()
    {
        CreateMap<ProductAttributeValue, CreateProductAttributeValueDto>().ReverseMap();
        CreateMap<ProductAttributeValue, CreateProductAttributeValueSubDto>().ReverseMap();
        CreateMap<ProductAttributeValue, UpdateProductAttributeValueDto>().ReverseMap();
        CreateMap<ProductAttributeValue, UpdateProductAttributeValueSubDto>().ReverseMap();

        CreateMap<ProductAttribute, ProductAttributeValueProductAttributeResponseDto>().ReverseMap();
        CreateMap<Product, ProductAttributeValueProductResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, ProductAttributeValueAttributeInputTypeResponseDto>().ReverseMap();
    }
}
