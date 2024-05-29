using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public BarcodeDetailLevel DetailLevel { get; set; }
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


        var currentBarcode = await _barcodeRepository.GetAsync(predicate: x => x.Id == request.Barcode.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.BarcodeAreas).Include(y => y.BarcodePrinters)
            );

        Barcode? barcode = _mapper.Map(request.Barcode, currentBarcode);
        barcode.UpdatedDate = DateTime.Now;

        barcode.BarcodeAreas.ToList().ForEach(x => { x.CreatedDate = barcode.CreatedDate; x.UpdatedDate = DateTime.Now; });
        barcode.BarcodePrinters.ToList().ForEach(x => { x.CreatedDate = barcode.CreatedDate; x.UpdatedDate = DateTime.Now; });

        await _barcodeRepository.UpdateAsync(barcode);

        if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
        {
            var response = await _barcodeRepository.GetAsync(predicate: x => x.Id == barcode.Id,
            include: x =>
            {
                IQueryable<Barcode> query = x;

                var detailLevel = request.DetailLevel;

                if (detailLevel.IncludeDepositorCompany)
                {
                    query = query.Include(y => y.DepositorCompany);
                }

                if (detailLevel.IncludeBarcodeAreas)
                {
                    query = query.Include(y => y.BarcodeAreas);
                }

                if (detailLevel.IncludeBarcodePrinters)
                {
                    query = query.Include(y => y.BarcodePrinters);

                    if (detailLevel.BarcodePrinterDetailLevel.IncludePrinter)
                    {
                        query = query.Include(y => y.BarcodePrinters).ThenInclude(m => m.Printer);
                    }
                }

                var includableQuery = query as IIncludableQueryable<Barcode, object>;
                return includableQuery;
            }, enableTracking: false, cancellationToken: cancellationToken);

            return _mapper.Map<UpdatedBarcodeResponse>(response);
        }
        else
        {
            var response = await _barcodeRepository.GetAsync(predicate: x => x.Id == barcode.Id, enableTracking: false, cancellationToken: cancellationToken);

            return _mapper.Map<UpdatedBarcodeResponse>(response);

        }

    }
}
