using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Profiles;

public class ContainerUnitMappingProfiles : Profile
{
    public ContainerUnitMappingProfiles()
    {
        //CreateContainerUnitCommand
        CreateMap<CreatedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //UpdateContainerUnitCommand
        CreateMap<UpdatedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //DeleteContainerUnitCommand
        CreateMap<DeletedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //GetByCodeContainerUnitQuery
        CreateMap<GetByCodeContainerUnitResponse, ContainerUnit>().ReverseMap();

        //GetByIdContainerUnitQuery
        CreateMap<GetByIdContainerUnitResponse, ContainerUnit>().ReverseMap();

        //GetListContainerUnitQuery
        CreateMap<ContainerUnit, GetListContainerUnitListItemDto>().ReverseMap();
        CreateMap<Paginate<ContainerUnit>, GetListResponse<GetListContainerUnitListItemDto>>().ReverseMap();

        //GetListByDynamicContainerUnitQuery
        CreateMap<ContainerUnit, GetListByDynamicContainerUnitListItemDto>().ReverseMap();
        CreateMap<Paginate<ContainerUnit>, GetListResponse<GetListByDynamicContainerUnitListItemDto>>().ReverseMap();
    }
}
