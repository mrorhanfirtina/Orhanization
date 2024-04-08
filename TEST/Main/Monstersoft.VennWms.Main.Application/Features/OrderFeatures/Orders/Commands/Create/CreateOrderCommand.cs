using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;

public class CreateOrderCommand : IRequest<CreatedOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrders";

    public CreateOrderDto Order { get; set; }
}
