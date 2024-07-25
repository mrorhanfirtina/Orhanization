using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;

public class UpdateBarcodePrinterCommand : IRequest<UpdatedBarcodePrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBarcodes"];

    public UpdateBarcodePrinterDto BarcodePrinter { get; set; }
    public BarcodePrintersDetailLevel DetailLevel { get; set; }


    public class UpdateBarcodePrinterCommandHandler : IRequestHandler<UpdateBarcodePrinterCommand, UpdatedBarcodePrinterResponse>
    {
        private readonly IBarcodePrinterRepository _barcodePrinterRepository;
        private readonly BarcodePrinterBusinessRules _barcodePrinterBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBarcodePrinterCommandHandler(IBarcodePrinterRepository barcodePrinterRepository, BarcodePrinterBusinessRules barcodePrinterBusinessRules, IMapper mapper)
        {
            _barcodePrinterRepository = barcodePrinterRepository;
            _barcodePrinterBusinessRules = barcodePrinterBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedBarcodePrinterResponse> Handle(UpdateBarcodePrinterCommand request, CancellationToken cancellationToken)
        {
            _barcodePrinterBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.BarcodePrinter.Id)
            .CheckPrinterIdExistence(request.BarcodePrinter.PrinterId)
            .CheckBarcodeIdExistence(request.BarcodePrinter.BarcodeId)
            .CheckAlreadyExistence(request.BarcodePrinter.PrinterId, request.BarcodePrinter.BarcodeId, request.BarcodePrinter.Id);

            BarcodePrinter? currentBarcodePrinter = await _barcodePrinterRepository.GetAsync(predicate: x => x.Id == request.BarcodePrinter.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            BarcodePrinter? barcodePrinter = _mapper.Map(request.BarcodePrinter, currentBarcodePrinter);
            barcodePrinter.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            await _barcodePrinterRepository.UpdateAsync(barcodePrinter);

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

                return _mapper.Map<UpdatedBarcodePrinterResponse>(response);
            }
            else
            {
                var response = await _barcodePrinterRepository.GetAsync(predicate: x => x.Id == barcodePrinter.Id, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBarcodePrinterResponse>(response);
            }
        }
    }

}
