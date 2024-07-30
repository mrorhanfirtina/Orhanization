using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Profiles;

public class ExpectedSerialsMappingProfiles : Profile
{
    public ExpectedSerialsMappingProfiles()
    {

        //CreateExpectedSerialCommand	
        CreateMap<CreatedExpectedSerialResponse, ExpectedSerial>().ReverseMap();

        //UpdateExpectedSerialCommand	
        CreateMap<UpdatedExpectedSerialResponse, ExpectedSerial>().ReverseMap();

        //DeleteExpectedSerialCommand	
        CreateMap<DeletedExpectedSerialResponse, ExpectedSerial>().ReverseMap();

        //GetByIdExpectedSerialQuery	
        CreateMap<GetByIdExpectedSerialResponse, ExpectedSerial>().ReverseMap();

        //GetListByDynamicExpectedSerialQuery	
        CreateMap<GetListByDynamicExpectedSerialListItemDto, ExpectedSerial>().ReverseMap();
        CreateMap<Paginate<ExpectedSerial>, GetListResponse<GetListByDynamicExpectedSerialListItemDto>>().ReverseMap();

    }
}
