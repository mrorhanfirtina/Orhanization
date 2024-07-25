using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants.ProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Delete;

public class DeleteProductAttributeCommand : IRequest<DeletedProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ProductAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductAttributes"];

    public Guid Id { get; set; }


    public class DeleteProductAttributeCommandHandler : IRequestHandler<DeleteProductAttributeCommand, DeletedProductAttributeResponse>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;

        public DeleteProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository, ProductAttributeBusinessRules productAttributeBusinessRules)
        {
            _productAttributeRepository = productAttributeRepository;
            _productAttributeBusinessRules = productAttributeBusinessRules;
        }

        public async Task<DeletedProductAttributeResponse> Handle(DeleteProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductAttribute productAttribute = await _productAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productAttributeRepository.DeleteAsync(productAttribute);

            return new DeletedProductAttributeResponse
            {
                Id = productAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}
