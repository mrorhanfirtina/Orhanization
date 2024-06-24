using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Profiles;

public class StorageSystemsMappingProfiles : Profile
{
    public StorageSystemsMappingProfiles()
    {

        //CreateStorageSystemCommand
        CreateMap<CreatedStorageSystemResponse, StorageSystem>().ReverseMap();

        //UpdateStorageSystemCommand
        CreateMap<UpdatedStorageSystemResponse, StorageSystem>().ReverseMap();

        //DeleteStorageSystemCommand
        CreateMap<DeletedStorageSystemResponse, StorageSystem>().ReverseMap();

        //GetByCodeStorageSystemQuery
        CreateMap<GetByCodeStorageSystemResponse, StorageSystem>().ReverseMap();

        //GetByIdStorageSystemQuery
        CreateMap<GetByIdStorageSystemResponse, StorageSystem>().ReverseMap();

        //GetListStorageSystemQuery
        CreateMap<GetListStorageSystemListItemDto, StorageSystem>().ReverseMap();
        CreateMap<Paginate<StorageSystem>, GetListResponse<GetListStorageSystemListItemDto>>().ReverseMap();

        //GetListByDynamicStorageSystemQuery
        CreateMap<GetListByDynamicStorageSystemListItemDto, StorageSystem>().ReverseMap();
        CreateMap<Paginate<StorageSystem>, GetListResponse<GetListByDynamicStorageSystemListItemDto>>().ReverseMap();

    }
}

