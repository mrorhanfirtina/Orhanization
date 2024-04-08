using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;

public class CreateOrderShipmentCommand : IRequest<CreatedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipments";

    public CreateOrderShipmentDto OrderShipment { get; set; }
}
