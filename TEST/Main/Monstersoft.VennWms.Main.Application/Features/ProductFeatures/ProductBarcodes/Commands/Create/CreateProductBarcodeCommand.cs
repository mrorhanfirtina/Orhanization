using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants.ProductBarcodeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;

public class CreateProductBarcodeCommand : IRequest<CreatedProductBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductBarcodes";

    public CreateProductBarcodeDto ProductBarcode { get; set; }
    public ProductBarcodeDetailLevel DetailLevel { get; set; }



    public class CreateProductBarcodeCommandHandler : IRequestHandler<CreateProductBarcodeCommand, CreatedProductBarcodeResponse>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly IMapper _mapper;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;

        public CreateProductBarcodeCommandHandler(IProductBarcodeRepository productBarcodeRepository, IMapper mapper, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _mapper = mapper;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
        }

        public async Task<CreatedProductBarcodeResponse> Handle(CreateProductBarcodeCommand request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            ProductBarcode? productBarcode = _mapper.Map<ProductBarcode>(request.ProductBarcode);

            productBarcode.CreatedDate = DateTime.Now;
            productBarcode.Id = Guid.NewGuid();

            productBarcode.BarcodeSuppliers?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            await _productBarcodeRepository.AddAsync(productBarcode);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productBarcodeRepository.GetAsync(predicate: x => x.Id == productBarcode.Id,
                include: x =>
                {
                    IQueryable<ProductBarcode> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeBarcodeSupplier)
                    {
                        query = query.Include(y => y.BarcodeSuppliers);

                        if (detailLevel.BarcodeSupplierDetailLevel.IncludeSupplier)
                        {
                            query = query.Include(y => y.BarcodeSuppliers).ThenInclude(y => y.Supplier);

                            if (detailLevel.BarcodeSupplierDetailLevel.SupplierDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.BarcodeSuppliers).ThenInclude(y => y.Supplier).ThenInclude(y => y.Company);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ProductBarcode, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductBarcodeResponse>(response);
            }
            else
            {
                var response = await _productBarcodeRepository.GetAsync(predicate: x => x.Id == productBarcode.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductBarcodeResponse>(response);
            }
        }
    }
}


