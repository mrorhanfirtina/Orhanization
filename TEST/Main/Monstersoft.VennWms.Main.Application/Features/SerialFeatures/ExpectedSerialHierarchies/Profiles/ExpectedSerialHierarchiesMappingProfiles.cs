using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Profiles;

public class ExpectedSerialHierarchiesMappingProfiles : Profile
{
    public ExpectedSerialHierarchiesMappingProfiles()
    {

        //CreateExpectedSerialHierarchyCommand	
        CreateMap<CreatedExpectedSerialHierarchyResponse, ExpectedSerialHierarchy>().ReverseMap();

        //UpdateExpectedSerialHierarchyCommand	
        CreateMap<UpdatedExpectedSerialHierarchyResponse, ExpectedSerialHierarchy>().ReverseMap();

        //DeleteExpectedSerialHierarchyCommand	
        CreateMap<DeletedExpectedSerialHierarchyResponse, ExpectedSerialHierarchy>().ReverseMap();

        //GetByIdExpectedSerialHierarchyQuery	
        CreateMap<GetByIdExpectedSerialHierarchyResponse, ExpectedSerialHierarchy>().ReverseMap();

        //GetListByDynamicExpectedSerialHierarchyQuery	
        CreateMap<GetListByDynamicExpectedSerialHierarchyListItemDto, ExpectedSerialHierarchy>().ReverseMap();
        CreateMap<Paginate<ExpectedSerialHierarchy>, GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>>().ReverseMap();

    }
}
