using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Update;

public class UpdateOrderCommand : IRequest<UpdatedOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrders";

    public UpdateOrderDto Order { get; set; }
}
