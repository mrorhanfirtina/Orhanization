using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Profiles;

public class ContainerUnitMappingProfiles : Profile
{
    public ContainerUnitMappingProfiles()
    {
        //CreateContainerUnitCommand
        CreateMap<CreateContainerUnitCommand, ContainerUnit>().ReverseMap();
        CreateMap<CreatedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //UpdateContainerUnitCommand
        CreateMap<UpdateContainerUnitCommand, ContainerUnit>().ReverseMap();
        CreateMap<UpdatedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //DeleteContainerUnitCommand
        CreateMap<DeletedContainerUnitResponse, ContainerUnit>().ReverseMap();

        //GetByCodeContainerUnitQuery
        CreateMap<GetByCodeContainerUnitQuery, ContainerUnit>().ReverseMap();
        CreateMap<GetByCodeContainerUnitResponse, ContainerUnit>().ReverseMap();

        //GetByIdContainerUnitQuery
        CreateMap<GetByIdContainerUnitQuery, ContainerUnit>().ReverseMap();
        CreateMap<GetByIdContainerUnitResponse, ContainerUnit>().ReverseMap();
    }
}
