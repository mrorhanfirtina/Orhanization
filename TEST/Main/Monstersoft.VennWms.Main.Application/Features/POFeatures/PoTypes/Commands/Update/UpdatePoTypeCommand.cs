using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants.PoTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;

public class UpdatePoTypeCommand : IRequest<UpdatedPoTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoTypes";

    public UpdatePoTypeDto PoType { get; set; }
}
