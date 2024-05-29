using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.DtoProfiles;

public class ReturnMemoDtoMappingProfiles : Profile
{
    public ReturnMemoDtoMappingProfiles()
    {
        CreateMap<ReturnMemo, CreateReturnMemoDto>().ReverseMap();
        CreateMap<ReturnMemo, CreateReturnMemoSubDto>().ReverseMap();
        CreateMap<ReturnMemo, UpdateReturnMemoDto>().ReverseMap();
        CreateMap<ReturnMemo, UpdateReturnMemoSubDto>().ReverseMap();
    }
}
