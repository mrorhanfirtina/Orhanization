using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;
using Orhanization.Core.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Dtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;

public class DeleteBarcodeCommand : IRequest<DeletedBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, 
    ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => $"GetBarcodes";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];

    public string Code { get; set; }
    public string DepositorCode { get; set; }
}

public class DeleteBarcodeCommandHandler : IRequestHandler<DeleteBarcodeCommand, DeletedBarcodeResponse>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly IBarcodeAreaRepository _barcodeAreaRepository;
    private readonly IPrinterRepository _printerRepository;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly IMapper _mapper;


    public DeleteBarcodeCommandHandler(IBarcodeRepository barcodeRepository, DepositorBusinessRules depositorBusinessRules, IBarcodeAreaRepository barcodeAreaRepository, IPrinterRepository printerRepository, BarcodeBusinessRules barcodeBusinessRules, IMapper mapper)
    {
        _barcodeRepository = barcodeRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _barcodeAreaRepository = barcodeAreaRepository;
        _printerRepository = printerRepository;
        _barcodeBusinessRules = barcodeBusinessRules;
        _mapper = mapper;
    }

    public async Task<DeletedBarcodeResponse> Handle(DeleteBarcodeCommand request, CancellationToken cancellationToken)
    {
        //Önce depositor kodunu doğrulayıp depositor kaydını aldık.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        var depositor = await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);

        //Barkod kodu gerçekten var mı? Varsa barkod bilgisi dönülecek.
        Barcode? barcode = await _barcodeBusinessRules.BarcodeCodeMustBeValidWhenDelete(request.Code, depositor.Id);
        //Barkoda ait barcode area verisi çekilir.
        var barcodeAreas = await _barcodeAreaRepository.GetListNoPaginateAsync(predicate: p => p.BarcodeId == barcode.Id, enableTracking: false);
        //Barkoda ait printer verisi çekilir.
        var printers = await _printerRepository.GetListNoPaginateAsync(predicate: p => p.BarcodeId == barcode.Id, enableTracking: false);

        //Barkod'a soft delete işlemi yapılır.
        var result = _mapper.Map<DeletedBarcodeResponse>(await _barcodeRepository.DeleteAsync(barcode, permanent: false));
        //Barkod alanlarına soft delete işlemi yapılır.
        await _barcodeAreaRepository.DeleteRangeAsync(barcodeAreas.ToList(), permanent: false);
        //Barkod'a ait printerlara soft delete işlemi yapılır.
        await _printerRepository.DeleteRangeAsync(printers.ToList(), permanent: false);

        //Response mesajı hazırlanır.
        result.DepositorCode = depositor.Code;
        result.Message = BarcodeMessages.DeleteRequestExecutedSuccessfully;
        result.IsSuccess = true;

        //Response döner.
        return result;
    }
}

