using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants.BarcodeSupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetList;

public class GetListBarcodeSupplierQuery : IRequest<GetListResponse<GetListBarcodeSupplierListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListBarcodeSupplierQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetBarcodeSuppliers";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public BarcodeSupplierDetailLevel DetailLevel { get; set; }



    public class GetListBarcodeSupplierQueryHandler : IRequestHandler<GetListBarcodeSupplierQuery, GetListResponse<GetListBarcodeSupplierListItemDto>>
    {
        private readonly IBarcodeSupplierRepository _barcodeSupplierRepository;
        private readonly BarcodeSupplierBusinessRules _barcodeSupplierBusinessRules;
        private readonly IMapper _mapper;

        public GetListBarcodeSupplierQueryHandler(IBarcodeSupplierRepository barcodeSupplierRepository, IMapper mapper, BarcodeSupplierBusinessRules barcodeSupplierBusinessRules)
        {
            _barcodeSupplierRepository = barcodeSupplierRepository;
            _mapper = mapper;
            _barcodeSupplierBusinessRules = barcodeSupplierBusinessRules;
        }

        public async Task<GetListResponse<GetListBarcodeSupplierListItemDto>> Handle(GetListBarcodeSupplierQuery request, CancellationToken cancellationToken)
        {
            _barcodeSupplierBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<BarcodeSupplier> barcodeSupplierList = await _barcodeSupplierRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
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
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListBarcodeSupplierListItemDto>>(barcodeSupplierList);
            }
            else
            {
                Paginate<BarcodeSupplier> barcodeSupplierList = await _barcodeSupplierRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListBarcodeSupplierListItemDto>>(barcodeSupplierList);
            }
        }
    }

}
