using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants.ProductCategoryListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Delete;

public class DeleteProductCategoryListCommand : IRequest<DeletedProductCategoryListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductCategoryListOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductCategoryLists"];

    public int Id { get; set; }

    public class DeleteProductCategoryListCommandHandler : IRequestHandler<DeleteProductCategoryListCommand, DeletedProductCategoryListResponse>
    {
        private readonly IProductCategoryListRepository _productCategoryListRepository;
        private readonly ProductCategoryListBusinessRules _productCategoryListBusinessRules;

        public DeleteProductCategoryListCommandHandler(IProductCategoryListRepository productCategoryListRepository, ProductCategoryListBusinessRules productCategoryListBusinessRules)
        {
            _productCategoryListRepository = productCategoryListRepository;
            _productCategoryListBusinessRules = productCategoryListBusinessRules;
        }

        public async Task<DeletedProductCategoryListResponse> Handle(DeleteProductCategoryListCommand request, CancellationToken cancellationToken)
        {
            _productCategoryListBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategoryList productCategoryList = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productCategoryListRepository.DeleteAsync(productCategoryList);

            return new DeletedProductCategoryListResponse
            {
                Id = productCategoryList.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductCategoryListMessages.RequestExecutedSuccessfully
            };
        }
    }
}


