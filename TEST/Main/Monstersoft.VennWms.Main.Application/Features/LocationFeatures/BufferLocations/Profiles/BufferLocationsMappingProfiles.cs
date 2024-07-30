using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Profiles;

public class BufferLocationsMappingProfiles : Profile
{
    public BufferLocationsMappingProfiles()
    {

        //CreateBufferLocationCommand	
        CreateMap<CreatedBufferLocationResponse, BufferLocation>().ReverseMap();

        //UpdateBufferLocationCommand	
        CreateMap<UpdatedBufferLocationResponse, BufferLocation>().ReverseMap();

        //DeleteBufferLocationCommand	
        CreateMap<DeletedBufferLocationResponse, BufferLocation>().ReverseMap();

        //GetByIdBufferLocationQuery	
        CreateMap<GetByIdBufferLocationResponse, BufferLocation>().ReverseMap();

        //GetListByDynamicBufferLocationQuery	
        CreateMap<GetListByDynamicBufferLocationListItemDto, BufferLocation>().ReverseMap();
        CreateMap<Paginate<BufferLocation>, GetListResponse<GetListByDynamicBufferLocationListItemDto>>().ReverseMap();

    }
}
