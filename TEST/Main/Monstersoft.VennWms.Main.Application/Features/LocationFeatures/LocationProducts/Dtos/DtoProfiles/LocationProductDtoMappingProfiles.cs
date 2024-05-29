using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoProfiles;

public class LocationProductDtoMappingProfiles : Profile
{
    public LocationProductDtoMappingProfiles()
    {
        CreateMap<LocationProduct, CreateLocationProductDto>().ReverseMap();
        CreateMap<LocationProduct, CreateLocationProductSubDto>().ReverseMap();
        CreateMap<LocationProduct, UpdateLocationProductDto>().ReverseMap();
        CreateMap<LocationProduct, UpdateLocationProductSubDto>().ReverseMap();

        CreateMap<Location, LocationProductLocationResponseDto>().ReverseMap();
        CreateMap<Product, LocationProductProductResponseDto>().ReverseMap();
    }
}
