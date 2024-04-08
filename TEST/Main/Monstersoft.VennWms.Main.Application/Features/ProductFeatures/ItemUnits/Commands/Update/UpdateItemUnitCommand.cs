using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;

public class UpdateItemUnitCommand : IRequest<UpdatedItemUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ItemUnitOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnits";

    public UpdateItemUnitDto ItemUnit { get; set; }
}
