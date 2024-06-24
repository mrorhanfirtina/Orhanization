using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Profiles;

public class ReturnAttributeValuesMappingProfiles : Profile
{
    public ReturnAttributeValuesMappingProfiles()
    {

        //CreateReturnAttributeValueCommand
        CreateMap<CreatedReturnAttributeValueResponse, ReturnAttributeValue>().ReverseMap();

        //UpdateReturnAttributeValueCommand
        CreateMap<UpdatedReturnAttributeValueResponse, ReturnAttributeValue>().ReverseMap();

        //DeleteReturnAttributeValueCommand
        CreateMap<DeletedReturnAttributeValueResponse, ReturnAttributeValue>().ReverseMap();

        //GetByIdReturnAttributeValueQuery
        CreateMap<GetByIdReturnAttributeValueResponse, ReturnAttributeValue>().ReverseMap();

        //GetListByDynamicReturnAttributeValueQuery
        CreateMap<GetListByDynamicReturnAttributeValueListItemDto, ReturnAttributeValue>().ReverseMap();
        CreateMap<Paginate<ReturnAttributeValue>, GetListResponse<GetListByDynamicReturnAttributeValueListItemDto>>().ReverseMap();

    }
}

