using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants.PrinterOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Create;

public class CreatePrinterCommand : IRequest<CreatedPrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodes";

    public CreatePrinterDto Printer { get; set; }
    public PrinterDetailLevel DetailLevel { get; set; }


    public class CreatePrinterCommandHandler : IRequestHandler<CreatePrinterCommand, CreatedPrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public CreatePrinterCommandHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _mapper = mapper;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<CreatedPrinterResponse> Handle(CreatePrinterCommand request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Printer.Code);

            Printer printer = _mapper.Map<Printer>(request.Printer);
            printer.Id = Guid.NewGuid();
            printer.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            printer.CreatedDate = DateTime.Now;

            await _printerRepository.AddAsync(printer);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _printerRepository.GetAsync(predicate: x => x.Id == printer.Id,
                include: x =>
                {
                    IQueryable<Printer> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<Printer, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPrinterResponse>(response);
            }
            else
            {
                var response = await _printerRepository.GetAsync(predicate: x => x.Id == printer.Id, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPrinterResponse>(response);

            }
        }
    }

}


