using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Rules;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;

public class UpdateProductBarcodeCommand : IRequest<UpdatedProductBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ProductBarcodeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductBarcodes";

    public UpdateProductBarcodeDto ProductBarcode { get; set; }
    public ProductBarcodeDetailLevel DetailLevel { get; set; }



    public class UpdateProductBarcodeCommandHandler : IRequestHandler<UpdateProductBarcodeCommand, UpdatedProductBarcodeResponse>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly IMapper _mapper;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;

        public UpdateProductBarcodeCommandHandler(IProductBarcodeRepository productBarcodeRepository, IMapper mapper, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _mapper = mapper;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
        }

        public async Task<UpdatedProductBarcodeResponse> Handle(UpdateProductBarcodeCommand request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ProductBarcode.Id);

            ProductBarcode? currentProductBarcode = await _productBarcodeRepository.GetAsync(predicate: x => x.Id == request.ProductBarcode.Id,
            include: x => x.Include(y => y.BarcodeSuppliers),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            ProductBarcode? productBarcode = _mapper.Map<ProductBarcode>(request.ProductBarcode);

            productBarcode.CreatedDate = currentProductBarcode.CreatedDate;
            productBarcode.UpdatedDate = DateTime.Now;

            productBarcode.BarcodeSuppliers?.ToList().ForEach(x =>
            {
                x.CreatedDate = productBarcode.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            await _productBarcodeRepository.UpdateAsync(productBarcode);

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

                return _mapper.Map<UpdatedProductBarcodeResponse>(response);
            }
            else
            {
                var response = await _productBarcodeRepository.GetAsync(predicate: x => x.Id == productBarcode.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductBarcodeResponse>(response);
            }
        }
    }
}


