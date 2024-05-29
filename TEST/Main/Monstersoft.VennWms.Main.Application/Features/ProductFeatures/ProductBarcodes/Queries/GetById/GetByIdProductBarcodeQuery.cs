using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants.ProductBarcodeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetById;

public class GetByIdProductBarcodeQuery : IRequest<GetByIdProductBarcodeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ProductBarcodeDetailLevel DetailLevel { get; set; }



    public class GetByIdProductBarcodeQueryHandler : IRequestHandler<GetByIdProductBarcodeQuery, GetByIdProductBarcodeResponse>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductBarcodeQueryHandler(IProductBarcodeRepository productBarcodeRepository, IMapper mapper, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _mapper = mapper;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
        }

        public async Task<GetByIdProductBarcodeResponse> Handle(GetByIdProductBarcodeQuery request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdProductBarcodeResponse>(await _productBarcodeRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdProductBarcodeResponse>(await _productBarcodeRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}


