using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants.ProductStockAttributeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Delete;

public class DeleteProductStockAttributeCommand : IRequest<DeletedProductStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductStockAttributeOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductStockAttributes";

    public Guid Id { get; set; }


    public class DeleteProductStockAttributeCommandHandler : IRequestHandler<DeleteProductStockAttributeCommand, DeletedProductStockAttributeResponse>
    {
        private readonly IProductStockAttributeRepository _productStockAttributeRepository;
        private readonly ProductStockAttributeBusinessRules _productStockAttributeBusinessRules;

        public DeleteProductStockAttributeCommandHandler(IProductStockAttributeRepository productStockAttributeRepository, ProductStockAttributeBusinessRules productStockAttributeBusinessRules)
        {
            _productStockAttributeRepository = productStockAttributeRepository;
            _productStockAttributeBusinessRules = productStockAttributeBusinessRules;
        }

        public async Task<DeletedProductStockAttributeResponse> Handle(DeleteProductStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _productStockAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductStockAttribute productStockAttribute = await _productStockAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _productStockAttributeRepository.DeleteAsync(productStockAttribute);

            return new DeletedProductStockAttributeResponse
            {
                Id = productStockAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductStockAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

