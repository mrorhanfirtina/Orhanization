using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;

public class UpdateLogStockCommand : IRequest<UpdatedLogStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LogStockOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLogStocks";

    public UpdateLogStockDto LogStock { get; set; }
}

