using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants.BarcodePrinterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;

public class CreateBarcodePrinterCommand : IRequest<CreatedBarcodePrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodes";

    public CreateBarcodePrinterDto BarcodePrinter { get; set; }
    public BarcodePrintersDetailLevel DetailLevel { get; set; }


    public class CreateBarcodePrinterCommandHandler : IRequestHandler<CreateBarcodePrinterCommand, CreatedBarcodePrinterResponse>
    {
        private readonly IBarcodePrinterRepository _barcodePrinterRepository;
        private readonly BarcodePrinterBusinessRules _barcodePrinterBusinessRules;
        private readonly IMapper _mapper;

        public CreateBarcodePrinterCommandHandler(IBarcodePrinterRepository barcodePrinterRepository, IMapper mapper, BarcodePrinterBusinessRules barcodePrinterBusinessRules)
        {
            _barcodePrinterRepository = barcodePrinterRepository;
            _mapper = mapper;
            _barcodePrinterBusinessRules = barcodePrinterBusinessRules;
        }

        public async Task<CreatedBarcodePrinterResponse> Handle(CreateBarcodePrinterCommand request, CancellationToken cancellationToken)
        {
            _barcodePrinterBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckPrinterIdExistence(request.BarcodePrinter.PrinterId)
                .CheckBarcodeIdExistence(request.BarcodePrinter.BarcodeId)
                .CheckAlreadyExistence(request.BarcodePrinter.PrinterId, request.BarcodePrinter.BarcodeId);

            BarcodePrinter barcodePrinter = _mapper.Map<BarcodePrinter>(request.BarcodePrinter);
            barcodePrinter.Id = Guid.NewGuid();
            barcodePrinter.CreatedDate = DateTime.Now;

            await _barcodePrinterRepository.AddAsync(barcodePrinter);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _barcodePrinterRepository.GetAsync(predicate: x => x.Id == barcodePrinter.Id,
                include: x =>
                {
                    IQueryable<BarcodePrinter> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeBarcode)
                    {
                        query = query.Include(y => y.Barcode);

                        if (detailLevel.BarcodeDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Barcode.DepositorCompany);
                        }
                    }

                    if (detailLevel.IncludePrinter)
                    {
                        query = query.Include(y => y.Printer);
                    }

                    var includableQuery = query as IIncludableQueryable<BarcodePrinter, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodePrinterResponse>(response);
            }
            else
            {
                var response = await _barcodePrinterRepository.GetAsync(predicate: x => x.Id == barcodePrinter.Id, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodePrinterResponse>(response);
            }

        }
    }
}

