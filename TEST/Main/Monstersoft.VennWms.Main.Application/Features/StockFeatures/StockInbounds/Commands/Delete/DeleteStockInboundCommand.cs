using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants.StockInboundOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Delete;

public class DeleteStockInboundCommand : IRequest<DeletedStockInboundResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, StockInboundOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockInbounds"];

    public Guid Id { get; set; }

    public class DeleteStockInboundCommandHandler : IRequestHandler<DeleteStockInboundCommand, DeletedStockInboundResponse>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;

        public DeleteStockInboundCommandHandler(IStockInboundRepository stockInboundRepository, StockInboundBusinessRules stockInboundBusinessRules)
        {
            _stockInboundRepository = stockInboundRepository;
            _stockInboundBusinessRules = stockInboundBusinessRules;
        }

        public async Task<DeletedStockInboundResponse> Handle(DeleteStockInboundCommand request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockInbound stockInbound = await _stockInboundRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockInboundRepository.DeleteAsync(stockInbound);

            return new DeletedStockInboundResponse
            {
                Id = stockInbound.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockInboundMessages.RequestExecutedSuccessfully
            };
        }
    }
}
