using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
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
    public string? CacheGroupKey => $"GetBarcodes()";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];


    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public virtual ICollection<CreateBarcodeBarcodeAreaDto>? BarcodeAreas { get; set; }
    public virtual ICollection<CreateBarcodePrinterDto>? Printers { get; set; }
    
}

public class CreateBarcodeCommandHandler : IRequestHandler<CreateBarcodeCommand, CreatedBarcodeResponse>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly IMapper _mapper;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly PrinterBusinessRules _printerBusinessRules;

    public CreateBarcodeCommandHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules, DepositorBusinessRules depositorBusinessRules, PrinterBusinessRules printerBusinessRules)
    {
        _barcodeRepository = barcodeRepository;
        _mapper = mapper;
        _barcodeBusinessRules = barcodeBusinessRules;
        _depositorBusinessRules = depositorBusinessRules;
        _printerBusinessRules = printerBusinessRules;
    }

    public async Task<CreatedBarcodeResponse> Handle(CreateBarcodeCommand request, CancellationToken cancellationToken)
    {
        //Önce user ile gelen depositor id gerçekten var mı ve aktif mi kontrol edilir.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        Depositor? depositor = await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);

        //Barkod kodunun mevcut depositor içinde halihazırda bulunup bulunmadığı kontrol edilir.
        await _barcodeBusinessRules.BarcodeCodeCannotBeDuplicatedWhenInsert(request.Code, depositor.Id);
        
        //İstekte gelen alanlar yeni bir Barcode sınıfına maplenir.
        Barcode barcode = _mapper.Map<Barcode>(request);

        //Gelen requestte printer verisinde mükerrer kod olup olmadığı kontrol edilir.
        await _printerBusinessRules.PrinterCodeCannotBeDuplicatedWhenInsert(barcode.Printers);

        //Kontrollerden geçtikten sonra Barkod nesnesi düzenlenir.
        barcode.DepositorId = depositor.Id;
        barcode.Id = Guid.NewGuid();
        barcode.CreatedDate = DateTime.Now;

        //BarkodArea sınıfları düzenlenir.
        foreach (var barcodeArea in barcode.BarcodeAreas)
        {
            barcodeArea.CreatedDate = DateTime.Now;
            barcodeArea.Id = Guid.NewGuid();
            barcodeArea.BarcodeId = barcode.Id;
        }

        //Printer sınıfları düzenlenir.
        foreach (var printer in barcode.Printers)
        {
            printer.CreatedDate = DateTime.Now;
            printer.Id = Guid.NewGuid();
            printer.BarcodeId = barcode.Id;
        }

        //Ekleme işlemi yapılır ve gelen veri response nesnesine maplenir. Depositor kod eklenir.
        var response = _mapper.Map<CreatedBarcodeResponse>(await _barcodeRepository.AddAsync(barcode));
        response.DepositorCode = depositor.Code;

        //Cevap dönülür.
        return response;
    }
}
