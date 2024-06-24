using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.DtoProfiles;

public class DepositorFeatureDtoMappingProfiles : Profile
{
    public DepositorFeatureDtoMappingProfiles()
    {
        CreateMap<DepositorFeature, CreateDepositorFeatureDto>().ReverseMap();
        CreateMap<DepositorFeature, CreateDepositorFeatureSubDto>().ReverseMap();
        CreateMap<DepositorFeature, UpdateDepositorFeatureDto>().ReverseMap();
        CreateMap<DepositorFeature, UpdateDepositorFeatureSubDto>().ReverseMap();
    }
}
