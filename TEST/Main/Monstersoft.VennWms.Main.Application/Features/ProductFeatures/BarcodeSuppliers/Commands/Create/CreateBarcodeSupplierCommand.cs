using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;

public class CreateBarcodeSupplierCommand : IRequest<CreatedBarcodeSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodeSuppliers";

    public CreateBarcodeSupplierDto BarcodeSupplier { get; set; }


    public class CreateBarcodeSupplierCommandHandler : IRequestHandler<CreateBarcodeSupplierCommand, CreatedBarcodeSupplierResponse>
    {
        private readonly IBarcodeSupplierRepository _barcodeSupplierRepository;
        private readonly BarcodeSupplierBusinessRules _barcodeSupplierBusinessRules;
        private readonly IMapper _mapper;

        public CreateBarcodeSupplierCommandHandler(IBarcodeSupplierRepository barcodeSupplierRepository, IMapper mapper, BarcodeSupplierBusinessRules barcodeSupplierBusinessRules)
        {
            _barcodeSupplierRepository = barcodeSupplierRepository;
            _mapper = mapper;
            _barcodeSupplierBusinessRules = barcodeSupplierBusinessRules;
        }

        public async Task<CreatedBarcodeSupplierResponse> Handle(CreateBarcodeSupplierCommand request, CancellationToken cancellationToken)
        {
            _barcodeSupplierBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckProductBarcodeIdExistence(request.BarcodeSupplier.ProductBarcodeId)
                .CheckSupplierIdExistence(request.BarcodeSupplier.SupplierId);

            BarcodeSupplier barcodeSupplier = _mapper.Map<BarcodeSupplier>(request.BarcodeSupplier);
            barcodeSupplier.Id = Guid.NewGuid();
            barcodeSupplier.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            barcodeSupplier.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedBarcodeSupplierResponse>(await _barcodeSupplierRepository.AddAsync(barcodeSupplier));
        }
    }

}
