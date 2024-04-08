using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Profiles;

public class ReceiptAttributeValuesMappingProfiles : Profile
{
    public ReceiptAttributeValuesMappingProfiles()
    {

        //CreateReceiptAttributeValueCommand
        CreateMap<CreatedReceiptAttributeValueResponse, ReceiptAttributeValue>().ReverseMap();

        //UpdateReceiptAttributeValueCommand
        CreateMap<UpdatedReceiptAttributeValueResponse, ReceiptAttributeValue>().ReverseMap();

        //DeleteReceiptAttributeValueCommand
        CreateMap<DeletedReceiptAttributeValueResponse, ReceiptAttributeValue>().ReverseMap();

        //GetByIdReceiptAttributeValueQuery
        CreateMap<GetByIdReceiptAttributeValueResponse, ReceiptAttributeValue>().ReverseMap();

        //GetListByDynamicReceiptAttributeValueQuery
        CreateMap<GetListByDynamicReceiptAttributeValueListItemDto, ReceiptAttributeValue>().ReverseMap();
        CreateMap<Paginate<ReceiptAttributeValue>, GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>().ReverseMap();

    }
}
