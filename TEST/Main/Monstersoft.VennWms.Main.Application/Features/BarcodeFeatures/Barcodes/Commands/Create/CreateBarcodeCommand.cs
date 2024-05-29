using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.CreateDtos;
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
    public BarcodeDetailLevel DetailLevel { get; set; }
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

        barcode.BarcodeAreas.ToList().ForEach(x => { x.CreatedDate = barcode.CreatedDate;});
        barcode.BarcodePrinters.ToList().ForEach(x => { x.CreatedDate = barcode.CreatedDate;});

        await _barcodeRepository.AddAsync(barcode);

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

            return _mapper.Map<CreatedBarcodeResponse>(response);
        }
        else
        {
            var response = await _barcodeRepository.GetAsync(predicate: x => x.Id == barcode.Id,
            enableTracking: false,
            cancellationToken: cancellationToken);

            return _mapper.Map<CreatedBarcodeResponse>(response);

        }
    }
}
