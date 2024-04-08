using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;

public class UpdateBarcodeSupplierCommand : IRequest<UpdatedBarcodeSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, BarcodeSupplierOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodeSuppliers";

    public UpdateBarcodeSupplierDto BarcodeSupplier { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedBarcodeSupplierResponse>(await _barcodeSupplierRepository.UpdateAsync(barcodeSupplier));
        }
    }
}
