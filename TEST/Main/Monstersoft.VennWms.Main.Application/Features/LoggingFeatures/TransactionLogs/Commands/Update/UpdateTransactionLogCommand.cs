using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Update;

public class UpdateTransactionLogCommand : IRequest<UpdatedTransactionLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, TransactionLogOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionLogs";

    public UpdateTransactionLogDto TransactionLog { get; set; }
}
