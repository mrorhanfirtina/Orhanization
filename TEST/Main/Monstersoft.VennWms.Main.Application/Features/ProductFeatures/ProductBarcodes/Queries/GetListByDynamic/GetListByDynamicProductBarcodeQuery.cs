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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants.ProductBarcodeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetListByDynamic;

public class GetListByDynamicProductBarcodeQuery : IRequest<GetListResponse<GetListByDynamicProductBarcodeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ProductBarcodesDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicProductBarcodeQueryHandler : IRequestHandler<GetListByDynamicProductBarcodeQuery, GetListResponse<GetListByDynamicProductBarcodeListItemDto>>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductBarcodeQueryHandler(IProductBarcodeRepository productBarcodeRepository, IMapper mapper, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductBarcodeListItemDto>> Handle(GetListByDynamicProductBarcodeQuery request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ProductBarcode> productBarcodeList = await _productBarcodeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductBarcodeListItemDto>>(productBarcodeList);
            }
            else
            {
                Paginate<ProductBarcode> productBarcodeList = await _productBarcodeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductBarcodeListItemDto>>(productBarcodeList);
            }
        }
    }

}


