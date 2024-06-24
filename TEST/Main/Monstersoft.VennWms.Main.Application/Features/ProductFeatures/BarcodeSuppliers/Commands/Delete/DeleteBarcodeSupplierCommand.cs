using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants.BarcodeSupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Delete;

public class DeleteBarcodeSupplierCommand : IRequest<DeletedBarcodeSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, BarcodeSupplierOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodeSuppliers";

    public Guid Id { get; set; }


    public class DeleteBarcodeSupplierCommandHandler : IRequestHandler<DeleteBarcodeSupplierCommand, DeletedBarcodeSupplierResponse>
    {
        private readonly IBarcodeSupplierRepository _barcodeSupplierRepository;
        private readonly BarcodeSupplierBusinessRules _barcodeSupplierBusinessRules;

        public DeleteBarcodeSupplierCommandHandler(IBarcodeSupplierRepository barcodeSupplierRepository, BarcodeSupplierBusinessRules barcodeSupplierBusinessRules)
        {
            _barcodeSupplierRepository = barcodeSupplierRepository;
            _barcodeSupplierBusinessRules = barcodeSupplierBusinessRules;
        }

        public async Task<DeletedBarcodeSupplierResponse> Handle(DeleteBarcodeSupplierCommand request, CancellationToken cancellationToken)
        {
            _barcodeSupplierBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            BarcodeSupplier barcodeSupplier = await _barcodeSupplierRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _barcodeSupplierRepository.DeleteAsync(barcodeSupplier);

            return new DeletedBarcodeSupplierResponse
            {
                Id = barcodeSupplier.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BarcodeSupplierMessages.RequestExecutedSuccessfully
            };
        }
    }
}
