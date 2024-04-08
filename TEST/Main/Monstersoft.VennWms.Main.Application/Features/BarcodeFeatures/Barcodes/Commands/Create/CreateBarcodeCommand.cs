using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;

public class CreateBarcodeCommand : IRequest<CreatedBarcodeResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => $"GetBarcodes";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];


    public CreateBarcodeDto Barcode { get; set; }
}

public class CreateBarcodeCommandHandler : IRequestHandler<CreateBarcodeCommand, CreatedBarcodeResponse>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly IMapper _mapper;

    public CreateBarcodeCommandHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules)
    {
        _barcodeRepository = barcodeRepository;
        _barcodeBusinessRules = barcodeBusinessRules;
        _mapper = mapper;
        
    }

    public async Task<CreatedBarcodeResponse> Handle(CreateBarcodeCommand request, CancellationToken cancellationToken)
    {

        _barcodeBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.Barcode.Code)
            .CheckPrinterIdIsDuplicateInRequest(request.Barcode?.BarcodePrinters?.Select(x => x.PrinterId)?.ToArray() ?? new Guid[0]);

        Barcode barcode = _mapper.Map<Barcode>(request.Barcode);
        barcode.Id = Guid.NewGuid();
        barcode.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        barcode.CreatedDate = DateTime.Now;

        foreach (var item in barcode.BarcodeAreas)
        {
            BarcodeArea barcodeArea = _mapper.Map<BarcodeArea>(item);
            barcodeArea.Id = Guid.NewGuid();
            barcodeArea.BarcodeId = barcode.Id;
            barcodeArea.CreatedDate = DateTime.Now;
        }

        foreach (var item in barcode.BarcodePrinters)
        {
            _barcodeBusinessRules.CheckPrinterIdExistence(item.PrinterId);

            BarcodePrinter barcodePrinter = _mapper.Map<BarcodePrinter>(item);
            barcodePrinter.Id = Guid.NewGuid();
            barcodePrinter.BarcodeId = barcode.Id;
            barcodePrinter.CreatedDate = DateTime.Now;
        }

        return _mapper.Map<CreatedBarcodeResponse>(await _barcodeRepository.AddAsync(barcode));
    }
}
