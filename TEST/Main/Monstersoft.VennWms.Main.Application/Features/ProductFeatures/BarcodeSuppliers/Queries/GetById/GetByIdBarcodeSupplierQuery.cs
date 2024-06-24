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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants.BarcodeSupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetById;

public class GetByIdBarcodeSupplierQuery : IRequest<GetByIdBarcodeSupplierResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public BarcodeSuppliersDetailLevel DetailLevel { get; set; }



    public class GetByIdBarcodeSupplierQueryHandler : IRequestHandler<GetByIdBarcodeSupplierQuery, GetByIdBarcodeSupplierResponse>
    {
        private readonly IBarcodeSupplierRepository _barcodeSupplierRepository;
        private readonly BarcodeSupplierBusinessRules _barcodeSupplierBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBarcodeSupplierQueryHandler(IBarcodeSupplierRepository barcodeSupplierRepository, IMapper mapper, BarcodeSupplierBusinessRules barcodeSupplierBusinessRules)
        {
            _barcodeSupplierRepository = barcodeSupplierRepository;
            _mapper = mapper;
            _barcodeSupplierBusinessRules = barcodeSupplierBusinessRules;
        }

        public async Task<GetByIdBarcodeSupplierResponse> Handle(GetByIdBarcodeSupplierQuery request, CancellationToken cancellationToken)
        {
            _barcodeSupplierBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdBarcodeSupplierResponse>(await _barcodeSupplierRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBarcodeSupplierResponse>(await _barcodeSupplierRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
