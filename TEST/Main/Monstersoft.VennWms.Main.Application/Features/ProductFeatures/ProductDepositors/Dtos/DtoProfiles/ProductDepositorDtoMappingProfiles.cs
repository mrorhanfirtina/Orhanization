using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoProfiles;

public class ProductDepositorDtoMappingProfiles : Profile
{
    public ProductDepositorDtoMappingProfiles()
    {
        CreateMap<ProductDepositor, CreateProductDepositorDto>().ReverseMap();
        CreateMap<ProductDepositor, CreateProductDepositorSubDto>().ReverseMap();
        CreateMap<ProductDepositor, UpdateProductDepositorDto>().ReverseMap();
        CreateMap<ProductDepositor, UpdateProductDepositorSubDto>().ReverseMap();

        CreateMap<Depositor, ProductDepositorDepositorResponseDto>().ReverseMap();
        CreateMap<Product, ProductDepositorProductResponseDto>().ReverseMap();
    }
}
