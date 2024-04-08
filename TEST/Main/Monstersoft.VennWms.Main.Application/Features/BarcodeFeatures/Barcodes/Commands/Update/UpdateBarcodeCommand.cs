using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;

public class UpdateBarcodeCommand : IRequest<UpdatedBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, 
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => $"GetBarcodes";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, BarcodesOperationClaims.Update, Write];


    public UpdateBarcodeDto Barcode { get; set; }
}


public class UpdateBarcodeCommandHandler : IRequestHandler<UpdateBarcodeCommand, UpdatedBarcodeResponse>
{
    private readonly IMapper _mapper;
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;

    public UpdateBarcodeCommandHandler(IMapper mapper, IBarcodeRepository barcodeRepository, 
        BarcodeBusinessRules barcodeBusinessRules)
    {
        _mapper = mapper;
        _barcodeRepository = barcodeRepository;
        _barcodeBusinessRules = barcodeBusinessRules;
    }

    public async Task<UpdatedBarcodeResponse> Handle(UpdateBarcodeCommand request, CancellationToken cancellationToken)
    {
        _barcodeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckCodeExistenceWhenUpdate(request.Barcode.Code, request.Barcode.Id)
            .CheckIdExistence(request.Barcode.Id)
            .CheckPrinterIdIsDuplicateInRequest(request.Barcode?.BarcodePrinters?.Select(x => x.PrinterId)?.ToArray() ?? new Guid[0]);


        var currentBarcode = await _barcodeRepository.GetAsync(predicate: x => x.Id == request.Barcode.Id && !x.DeletedDate.HasValue);

        Barcode? barcode = _mapper.Map(request.Barcode, currentBarcode);
        barcode.UpdatedDate = DateTime.Now;

        await _barcodeRepository.DeleteAsync(currentBarcode, permanent: true);

        foreach (var newBarcodeArea in barcode.BarcodeAreas)
        {
                newBarcodeArea.CreatedDate = barcode.CreatedDate;
                newBarcodeArea.UpdatedDate = DateTime.Now;
                newBarcodeArea.Id = Guid.NewGuid();
                newBarcodeArea.BarcodeId = barcode.Id;
        }

        foreach (var newBarcodePrinter in barcode.BarcodePrinters)
        {
            _barcodeBusinessRules.CheckPrinterIdExistence(newBarcodePrinter.PrinterId);
            newBarcodePrinter.Id = Guid.NewGuid();
            newBarcodePrinter.BarcodeId = barcode.Id;
            newBarcodePrinter.CreatedDate = barcode.CreatedDate;
            newBarcodePrinter.UpdatedDate = DateTime.Now;
        }

        return _mapper.Map<UpdatedBarcodeResponse>(await _barcodeRepository.AddAsync(barcode));
    }
}
