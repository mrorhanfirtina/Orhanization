using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;

public class UpdateReturnItemCommand : IRequest<UpdatedReturnItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItems";

    public UpdateReturnItemDto ReturnItem { get; set; }
}
