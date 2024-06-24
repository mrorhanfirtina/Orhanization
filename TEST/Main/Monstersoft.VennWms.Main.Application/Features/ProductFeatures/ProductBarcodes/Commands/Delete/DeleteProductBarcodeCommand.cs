using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants.ProductBarcodeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Delete;

public class DeleteProductBarcodeCommand : IRequest<DeletedProductBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ProductBarcodeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductBarcodes";

    public Guid Id { get; set; }


    public class DeleteProductBarcodeCommandHandler : IRequestHandler<DeleteProductBarcodeCommand, DeletedProductBarcodeResponse>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;

        public DeleteProductBarcodeCommandHandler(IProductBarcodeRepository productBarcodeRepository, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
        }

        public async Task<DeletedProductBarcodeResponse> Handle(DeleteProductBarcodeCommand request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ProductBarcode productBarcode = await _productBarcodeRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.BarcodeSuppliers),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _productBarcodeRepository.DeleteAsync(productBarcode);

            return new DeletedProductBarcodeResponse
            {
                Id = productBarcode.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ProductBarcodeMessages.RequestExecutedSuccessfully
            };
        }
    }
}


