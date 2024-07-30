using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants.ProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Delete;

public class DeleteProductCommand : IRequest<DeletedProductResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ProductOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProducts"];

    public Guid Id { get; set; }


    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeletedProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductBusinessRules _productBusinessRules;

        public DeleteProductCommandHandler(IProductRepository productRepository, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<DeletedProductResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            _productBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Product product = await _productRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.ProductAbcCategory)
                           .Include(y => y.ProductCategory)
                           .Include(y => y.ProductAttributeValues)
                           .Include(y => y.ProductBarcodes)
                           .Include(y => y.ProductDepositors)
                           .Include(y => y.ProductStockAttributes)
                           .Include(y => y.ItemUnits)
                           .Include(y => y.ItemUnits).ThenInclude(z => z.ItemPackTypes),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _productRepository.DeleteAsync(product);

            return new DeletedProductResponse
            {
                Id = product.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductMessages.RequestExecutedSuccessfully
            };
        }
    }
}
