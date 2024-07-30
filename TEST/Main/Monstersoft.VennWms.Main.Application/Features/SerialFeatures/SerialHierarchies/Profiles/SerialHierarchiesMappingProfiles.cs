using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Profiles;

public class SerialHierarchiesMappingProfiles : Profile
{
    public SerialHierarchiesMappingProfiles()
    {

        //CreateSerialHierarchyCommand	
        CreateMap<CreatedSerialHierarchyResponse, SerialHierarchy>().ReverseMap();

        //UpdateSerialHierarchyCommand	
        CreateMap<UpdatedSerialHierarchyResponse, SerialHierarchy>().ReverseMap();

        //DeleteSerialHierarchyCommand	
        CreateMap<DeletedSerialHierarchyResponse, SerialHierarchy>().ReverseMap();

        //GetByIdSerialHierarchyQuery	
        CreateMap<GetByIdSerialHierarchyResponse, SerialHierarchy>().ReverseMap();

        //GetListByDynamicSerialHierarchyQuery	
        CreateMap<GetListByDynamicSerialHierarchyListItemDto, SerialHierarchy>().ReverseMap();
        CreateMap<Paginate<SerialHierarchy>, GetListResponse<GetListByDynamicSerialHierarchyListItemDto>>().ReverseMap();

    }
}
