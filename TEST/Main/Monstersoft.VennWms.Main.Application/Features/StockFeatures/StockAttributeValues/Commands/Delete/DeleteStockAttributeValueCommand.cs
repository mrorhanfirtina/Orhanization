using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants.StockAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Delete;

public class DeleteStockAttributeValueCommand : IRequest<DeletedStockAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockAttributeValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockAttributeValues";

    public Guid Id { get; set; }


    public class DeleteStockAttributeValueCommandHandler : IRequestHandler<DeleteStockAttributeValueCommand, DeletedStockAttributeValueResponse>
    {
        private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
        private readonly StockAttributeValueBusinessRules _stockAttributeValueBusinessRules;

        public DeleteStockAttributeValueCommandHandler(IStockAttributeValueRepository stockAttributeValueRepository, StockAttributeValueBusinessRules stockAttributeValueBusinessRules)
        {
            _stockAttributeValueRepository = stockAttributeValueRepository;
            _stockAttributeValueBusinessRules = stockAttributeValueBusinessRules;
        }

        public async Task<DeletedStockAttributeValueResponse> Handle(DeleteStockAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockAttributeValue stockAttributeValue = await _stockAttributeValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockAttributeValueRepository.DeleteAsync(stockAttributeValue);

            return new DeletedStockAttributeValueResponse
            {
                Id = stockAttributeValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockAttributeValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}

