using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Profiles;

public class UnitConversionMappingProfiles : Profile
{
    public UnitConversionMappingProfiles()
    {
        //CreateUnitConversionCommand
        CreateMap<CreatedUnitConversionResponse, UnitConversion>().ReverseMap();

        //UpdateUnitConversionCommand
        CreateMap<UpdatedUnitConversionResponse, UnitConversion>().ReverseMap();

        //DeleteUnitConversionCommand
        CreateMap<DeletedUnitConversionResponse, UnitConversion>().ReverseMap();

        //GetByIdUnitConversionQuery
        CreateMap<GetByIdUnitConversionResponse, UnitConversion>().ReverseMap();

        //GetListByDynamicUnitConversionQuery
        CreateMap<UnitConversion, GetListByDynamicUnitConversionListItemDto>().ReverseMap();
        CreateMap<Paginate<UnitConversion>, GetListResponse<GetListByDynamicUnitConversionListItemDto>>().ReverseMap();

    }
}
