using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.DtoProfiles;

public class ProductAttributeDtoMappingProfiles : Profile
{
    public ProductAttributeDtoMappingProfiles()
    {
        CreateMap<ProductAttribute, CreateProductAttributeDto>().ReverseMap();
        CreateMap<ProductAttribute, UpdateProductAttributeDto>().ReverseMap();

        CreateMap<AttributeInputType, ProductAttributeAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ProductAttributeDepositorCompanyResponseDto>().ReverseMap();
    }
}
