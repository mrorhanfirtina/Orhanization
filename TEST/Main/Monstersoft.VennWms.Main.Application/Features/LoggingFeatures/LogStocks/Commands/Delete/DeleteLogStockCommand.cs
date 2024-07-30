using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Delete;

public class DeleteLogStockCommand : IRequest<DeletedLogStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LogStockOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTransactionLogs"];

    public Guid Id { get; set; }


    public class DeleteLogStockCommandHandler : IRequestHandler<DeleteLogStockCommand, DeletedLogStockResponse>
    {
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;

        public DeleteLogStockCommandHandler(ILogStockRepository logStockRepository, LogStockBusinessRules logStockBusinessRules)
        {
            _logStockRepository = logStockRepository;
            _logStockBusinessRules = logStockBusinessRules;
        }

        public async Task<DeletedLogStockResponse> Handle(DeleteLogStockCommand request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LogStock logStock = await _logStockRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(z => z.LogStockAttributeValues)
                              .Include(z => z.LogStockContainers)
                              .Include(z => z.LogStockReserveReasons)
                              .Include(z => z.LogStockUnsuitReasons),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _logStockRepository.DeleteAsync(logStock);

            return new DeletedLogStockResponse
            {
                Id = logStock.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LogStockMessages.RequestExecutedSuccessfully
            };
        }
    }
}

