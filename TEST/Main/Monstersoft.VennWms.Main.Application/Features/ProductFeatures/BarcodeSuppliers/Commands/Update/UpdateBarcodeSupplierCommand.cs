using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants.BarcodeSupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;

public class UpdateBarcodeSupplierCommand : IRequest<UpdatedBarcodeSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, BarcodeSupplierOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBarcodeSuppliers"];

    public UpdateBarcodeSupplierDto BarcodeSupplier { get; set; }
    public BarcodeSuppliersDetailLevel DetailLevel { get; set; }



    public class UpdateBarcodeSupplierCommandHandler : IRequestHandler<UpdateBarcodeSupplierCommand, UpdatedBarcodeSupplierResponse>
    {
        private readonly IBarcodeSupplierRepository _barcodeSupplierRepository;
        private readonly BarcodeSupplierBusinessRules _barcodeSupplierBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBarcodeSupplierCommandHandler(IBarcodeSupplierRepository barcodeSupplierRepository, BarcodeSupplierBusinessRules barcodeSupplierBusinessRules, IMapper mapper)
        {
            _barcodeSupplierRepository = barcodeSupplierRepository;
            _barcodeSupplierBusinessRules = barcodeSupplierBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedBarcodeSupplierResponse> Handle(UpdateBarcodeSupplierCommand request, CancellationToken cancellationToken)
        {
            _barcodeSupplierBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.BarcodeSupplier.Id)
            .CheckProductBarcodeIdExistence(request.BarcodeSupplier.ProductBarcodeId)
            .CheckSupplierIdExistence(request.BarcodeSupplier.SupplierId);

            BarcodeSupplier? currentBarcodeSupplier = await _barcodeSupplierRepository.GetAsync(predicate: x => x.Id == request.BarcodeSupplier.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            BarcodeSupplier? barcodeSupplier = _mapper.Map(request.BarcodeSupplier, currentBarcodeSupplier);
            barcodeSupplier.UpdatedDate = DateTime.Now;

            await _barcodeSupplierRepository.UpdateAsync(barcodeSupplier);


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

                return _mapper.Map<UpdatedBarcodeSupplierResponse>(response);
            }
            else
            {
                var response = await _barcodeSupplierRepository.GetAsync(predicate: x => x.Id == barcodeSupplier.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBarcodeSupplierResponse>(response);
            }
        }
    }
}
