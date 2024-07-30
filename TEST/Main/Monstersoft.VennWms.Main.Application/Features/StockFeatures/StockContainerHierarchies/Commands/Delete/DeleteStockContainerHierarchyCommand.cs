using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants.StockContainerHierarchyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Delete;

public class DeleteStockContainerHierarchyCommand : IRequest<DeletedStockContainerHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockContainerHierarchyOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockContainerHierarchies"];

    public Guid Id { get; set; }


    public class DeleteStockContainerHierarchyCommandHandler : IRequestHandler<DeleteStockContainerHierarchyCommand, DeletedStockContainerHierarchyResponse>
    {
        private readonly IStockContainerHierarchyRepository _stockContainerHierarchyRepository;
        private readonly StockContainerHierarchyBusinessRules _stockContainerHierarchyBusinessRules;

        public DeleteStockContainerHierarchyCommandHandler(IStockContainerHierarchyRepository stockContainerHierarchyRepository, StockContainerHierarchyBusinessRules stockContainerHierarchyBusinessRules)
        {
            _stockContainerHierarchyRepository = stockContainerHierarchyRepository;
            _stockContainerHierarchyBusinessRules = stockContainerHierarchyBusinessRules;
        }

        public async Task<DeletedStockContainerHierarchyResponse> Handle(DeleteStockContainerHierarchyCommand request, CancellationToken cancellationToken)
        {
            _stockContainerHierarchyBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockContainerHierarchy stockContainerHierarchy = await _stockContainerHierarchyRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockContainerHierarchyRepository.DeleteAsync(stockContainerHierarchy);

            return new DeletedStockContainerHierarchyResponse
            {
                Id = stockContainerHierarchy.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
