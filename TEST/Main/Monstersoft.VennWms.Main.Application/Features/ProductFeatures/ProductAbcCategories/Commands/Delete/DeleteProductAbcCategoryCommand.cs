using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants.ProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Delete;

public class DeleteProductAbcCategoryCommand : IRequest<DeletedProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductAbcCategoryOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductAbcCategories"];

    public Guid Id { get; set; }

    public class DeleteProductAbcCategoryCommandHandler : IRequestHandler<DeleteProductAbcCategoryCommand, DeletedProductAbcCategoryResponse>
    {
        private readonly IProductAbcCategoryRepository _productAbcCategoryRepository;
        private readonly ProductAbcCategoryBusinessRules _productAbcCategoryBusinessRules;

        public DeleteProductAbcCategoryCommandHandler(IProductAbcCategoryRepository productAbcCategoryRepository, ProductAbcCategoryBusinessRules productAbcCategoryBusinessRules)
        {
            _productAbcCategoryRepository = productAbcCategoryRepository;
            _productAbcCategoryBusinessRules = productAbcCategoryBusinessRules;
        }

        public async Task<DeletedProductAbcCategoryResponse> Handle(DeleteProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _productAbcCategoryBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductAbcCategory productAbcCategory = await _productAbcCategoryRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productAbcCategoryRepository.DeleteAsync(productAbcCategory);

            return new DeletedProductAbcCategoryResponse
            {
                Id = productAbcCategory.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductAbcCategoryMessages.RequestExecutedSuccessfully
            };
        }
    }
}


