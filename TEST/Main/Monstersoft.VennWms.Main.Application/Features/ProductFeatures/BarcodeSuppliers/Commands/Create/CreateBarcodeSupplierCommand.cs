using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public BarcodeSuppliersDetailLevel DetailLevel { get; set; }



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

            await _barcodeSupplierRepository.AddAsync(barcodeSupplier);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _barcodeSupplierRepository.GetAsync(predicate: x => x.Id == barcodeSupplier.Id,
                include: x =>
                {
                    IQueryable<BarcodeSupplier> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeProductBarcode)
                    {
                        query = query.Include(y => y.ProductBarcode);
                    }

                    if (detailLevel.IncludeSupplier)
                    {
                        query = query.Include(y => y.Supplier);

                        if (detailLevel.SupplierDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Supplier).ThenInclude(m => m.Company);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<BarcodeSupplier, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodeSupplierResponse>(response);
            }
            else
            {
                var response = await _barcodeSupplierRepository.GetAsync(predicate: x => x.Id == barcodeSupplier.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodeSupplierResponse>(response);
            }
        }
    }

}
