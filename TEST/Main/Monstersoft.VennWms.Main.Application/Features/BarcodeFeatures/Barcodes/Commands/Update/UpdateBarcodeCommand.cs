using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;

public class UpdateBarcodeCommand : IRequest<UpdatedBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, 
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => $"GetBarcodes";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];


    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public virtual ICollection<UpdateBarcodeBarcodeAreaDto>? BarcodeAreas { get; set; }
    public virtual ICollection<UpdateBarcodePrinterDto>? Printers { get; set; }
}


public class UpdateBarcodeCommandHandler : IRequestHandler<UpdateBarcodeCommand, UpdatedBarcodeResponse>
{
    private readonly IMapper _mapper;
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly PrinterBusinessRules _printerBusinessRules;

    public UpdateBarcodeCommandHandler(IMapper mapper, IBarcodeRepository barcodeRepository, 
        DepositorBusinessRules depositorBusinessRules, BarcodeBusinessRules barcodeBusinessRules, 
        PrinterBusinessRules printerBusinessRules)
    {
        _mapper = mapper;
        _barcodeRepository = barcodeRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _barcodeBusinessRules = barcodeBusinessRules;
        _printerBusinessRules = printerBusinessRules;
    }

    public async Task<UpdatedBarcodeResponse> Handle(UpdateBarcodeCommand request, CancellationToken cancellationToken)
    {
        //Önce depositor kodunu doğrulayıp depositor kaydını aldık.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        Depositor depositor = await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);

        //Barkodu doğrulayıp barkodu aldık.
        Barcode oldBarcode = await _barcodeBusinessRules.BarcodeCodeMustBeValidWhenUpdate(request.Code, depositor.Id);

        //Mevcut barkod kaydını ve bağlı tabloları kalıcı olarak sildik.
        await _barcodeRepository.DeleteAsync(oldBarcode, permanent: true);

        //Tekrar insert etmeden önce barkod kodunun çoklayıp çoklamadığına baktık.
        await _barcodeBusinessRules.BarcodeCodeCannotBeDuplicatedWhenInsert(request.Code, depositor.Id);

        //İstekte gelen yeni bilgiler oluşturulan Barcode sınıfına maplenir.
        Barcode barcode = _mapper.Map<Barcode>(request);

        //Gelen kayıt içinde yazıcı kodlarının çoklayıp çoklamadığına bakılacak.
        await _printerBusinessRules.PrinterCodeCannotBeDuplicatedWhenInsert(barcode.Printers);

        //Request ile gelen Barkod alanları duzenlenir.
        barcode.DepositorId = depositor.Id;
        barcode.Id = oldBarcode.Id;
        barcode.CreatedDate = oldBarcode.CreatedDate;
        barcode.UpdatedDate = DateTime.Now;

        //Request ile gelen yeni barkod alanları düzenlenir.
        foreach (var barcodeArea in barcode.BarcodeAreas)
        {
            barcodeArea.CreatedDate = oldBarcode.CreatedDate;
            barcodeArea.UpdatedDate = DateTime.Now;
            barcodeArea.Id = Guid.NewGuid();
            barcodeArea.BarcodeId = barcode.Id;
        }

        //Request ile gelen yeni printer alanları düzenlenir.
        foreach (var printer in barcode.Printers)
        {
            printer.CreatedDate = oldBarcode.CreatedDate;
            printer.UpdatedDate = DateTime.Now;
            printer.Id = Guid.NewGuid();
            printer.BarcodeId = barcode.Id;
        }

        //Yeni barkod eklenir ve depositor kodu alanı depositordan gelen koda göre düzenlenir.
        var response = _mapper.Map<UpdatedBarcodeResponse>(await _barcodeRepository.AddAsync(barcode));
        response.DepositorCode = depositor.Code;

        //Cevap dönülür.
        return response;
    }
}
