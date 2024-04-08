using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Commands.Delete;

public class DeleteStockContainerCommand : IRequest<DeletedStockContainerResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockContainerOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockContainers";

    public Guid Id { get; set; }


    public class DeleteStockContainerCommandHandler : IRequestHandler<DeleteStockContainerCommand, DeletedStockContainerResponse>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;

        public DeleteStockContainerCommandHandler(IStockContainerRepository stockContainerRepository, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _stockContainerBusinessRules = stockContainerBusinessRules;
        }

        public async Task<DeletedStockContainerResponse> Handle(DeleteStockContainerCommand request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockContainer stockContainer = await _stockContainerRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockContainerRepository.DeleteAsync(stockContainer);

            return new DeletedStockContainerResponse
            {
                Id = stockContainer.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockContainerMessages.RequestExecutedSuccessfully
            };
        }
    }
}
