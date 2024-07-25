using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants.ProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Delete;

public class DeleteProductCategoryCommand : IRequest<DeletedProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductCategoryOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductCategories"];

    public Guid Id { get; set; }

    public class DeleteProductCategoryCommandHandler : IRequestHandler<DeleteProductCategoryCommand, DeletedProductCategoryResponse>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly ProductCategoryBusinessRules _productCategoryBusinessRules;

        public DeleteProductCategoryCommandHandler(IProductCategoryRepository productCategoryRepository, ProductCategoryBusinessRules productCategoryBusinessRules)
        {
            _productCategoryRepository = productCategoryRepository;
            _productCategoryBusinessRules = productCategoryBusinessRules;
        }

        public async Task<DeletedProductCategoryResponse> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _productCategoryBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategory productCategory = await _productCategoryRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productCategoryRepository.DeleteAsync(productCategory);

            return new DeletedProductCategoryResponse
            {
                Id = productCategory.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductCategoryMessages.RequestExecutedSuccessfully
            };
        }
    }
}

