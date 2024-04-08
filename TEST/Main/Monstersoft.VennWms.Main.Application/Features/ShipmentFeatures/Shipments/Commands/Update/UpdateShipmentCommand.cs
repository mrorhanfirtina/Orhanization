using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Update;

public class UpdateShipmentCommand : IRequest<UpdatedShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipments";

    public UpdateShipmentDto Shipment { get; set; }
}
