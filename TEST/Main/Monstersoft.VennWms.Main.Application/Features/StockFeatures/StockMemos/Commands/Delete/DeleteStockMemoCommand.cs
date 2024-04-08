using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants.StockMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Delete;

public class DeleteStockMemoCommand : IRequest<DeletedStockMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockMemos";

    public Guid Id { get; set; }


    public class DeleteStockMemoCommandHandler : IRequestHandler<DeleteStockMemoCommand, DeletedStockMemoResponse>
    {
        private readonly IStockMemoRepository _stockMemoRepository;
        private readonly StockMemoBusinessRules _stockMemoBusinessRules;

        public DeleteStockMemoCommandHandler(IStockMemoRepository stockMemoRepository, StockMemoBusinessRules stockMemoBusinessRules)
        {
            _stockMemoRepository = stockMemoRepository;
            _stockMemoBusinessRules = stockMemoBusinessRules;
        }

        public async Task<DeletedStockMemoResponse> Handle(DeleteStockMemoCommand request, CancellationToken cancellationToken)
        {
            _stockMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockMemo stockMemo = await _stockMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockMemoRepository.DeleteAsync(stockMemo);

            return new DeletedStockMemoResponse
            {
                Id = stockMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}
