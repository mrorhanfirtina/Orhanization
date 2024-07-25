using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Delete;

public class DeleteStockAttributeCommand : IRequest<DeletedStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockAttributes"];

    public Guid Id { get; set; }


    public class DeleteStockAttributeCommandHandler : IRequestHandler<DeleteStockAttributeCommand, DeletedStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;

        public DeleteStockAttributeCommandHandler(IStockAttributeRepository stockAttributeRepository, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
        }

        public async Task<DeletedStockAttributeResponse> Handle(DeleteStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockAttribute stockAttribute = await _stockAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockAttributeRepository.DeleteAsync(stockAttribute);

            return new DeletedStockAttributeResponse
            {
                Id = stockAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}
