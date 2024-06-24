using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants.StockUnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Delete;

public class DeleteStockUnsuitReasonCommand : IRequest<DeletedStockUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockUnsuitReasonOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockUnsuitReasons";

    public Guid Id { get; set; }


    public class DeleteStockUnsuitReasonCommandHandler : IRequestHandler<DeleteStockUnsuitReasonCommand, DeletedStockUnsuitReasonResponse>
    {
        private readonly IStockUnsuitReasonRepository _stockUnsuitReasonRepository;
        private readonly StockUnsuitReasonBusinessRules _stockUnsuitReasonBusinessRules;

        public DeleteStockUnsuitReasonCommandHandler(IStockUnsuitReasonRepository stockUnsuitReasonRepository, StockUnsuitReasonBusinessRules stockUnsuitReasonBusinessRules)
        {
            _stockUnsuitReasonRepository = stockUnsuitReasonRepository;
            _stockUnsuitReasonBusinessRules = stockUnsuitReasonBusinessRules;
        }

        public async Task<DeletedStockUnsuitReasonResponse> Handle(DeleteStockUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _stockUnsuitReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockUnsuitReason stockUnsuitReason = await _stockUnsuitReasonRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockUnsuitReasonRepository.DeleteAsync(stockUnsuitReason);

            return new DeletedStockUnsuitReasonResponse
            {
                Id = stockUnsuitReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockUnsuitReasonMessages.RequestExecutedSuccessfully
            };
        }
    }
}
