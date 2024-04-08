using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
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
    public string? CacheGroupKey => "GetPrinters";

    public CreatePrinterDto Printer { get; set; }


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

            return _mapper.Map<CreatedPrinterResponse>(await _printerRepository.AddAsync(printer));
        }
    }

}


