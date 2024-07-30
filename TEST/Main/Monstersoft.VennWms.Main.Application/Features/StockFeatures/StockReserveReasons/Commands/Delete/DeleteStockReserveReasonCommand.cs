using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants.StockReserveReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Delete;

public class DeleteStockReserveReasonCommand : IRequest<DeletedStockReserveReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockReserveReasonOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockReserveReasons"];

    public Guid Id { get; set; }


    public class DeleteStockReserveReasonCommandHandler : IRequestHandler<DeleteStockReserveReasonCommand, DeletedStockReserveReasonResponse>
    {
        private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
        private readonly StockReserveReasonBusinessRules _stockReserveReasonBusinessRules;

        public DeleteStockReserveReasonCommandHandler(IStockReserveReasonRepository stockReserveReasonRepository, StockReserveReasonBusinessRules stockReserveReasonBusinessRules)
        {
            _stockReserveReasonRepository = stockReserveReasonRepository;
            _stockReserveReasonBusinessRules = stockReserveReasonBusinessRules;
        }

        public async Task<DeletedStockReserveReasonResponse> Handle(DeleteStockReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _stockReserveReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockReserveReason stockReserveReason = await _stockReserveReasonRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockReserveReasonRepository.DeleteAsync(stockReserveReason);

            return new DeletedStockReserveReasonResponse
            {
                Id = stockReserveReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockReserveReasonMessages.RequestExecutedSuccessfully
            };
        }
    }
}

