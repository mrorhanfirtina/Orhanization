using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants.ProductDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Delete;

public class DeleteProductDepositorCommand : IRequest<DeletedProductDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductDepositorOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductDepositors";

    public Guid Id { get; set; }


    public class DeleteProductDepositorCommandHandler : IRequestHandler<DeleteProductDepositorCommand, DeletedProductDepositorResponse>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;

        public DeleteProductDepositorCommandHandler(IProductDepositorRepository productDepositorRepository, ProductDepositorBusinessRules productDepositorBusinessRules)
        {
            _productDepositorRepository = productDepositorRepository;
            _productDepositorBusinessRules = productDepositorBusinessRules;
        }

        public async Task<DeletedProductDepositorResponse> Handle(DeleteProductDepositorCommand request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductDepositor productDepositor = await _productDepositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productDepositorRepository.DeleteAsync(productDepositor);

            return new DeletedProductDepositorResponse
            {
                Id = productDepositor.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = productDepositor.DepositorId,
                IsSuccess = true,
                Message = ProductDepositorMessages.RequestExecutedSuccessfully
            };
        }
    }
}


