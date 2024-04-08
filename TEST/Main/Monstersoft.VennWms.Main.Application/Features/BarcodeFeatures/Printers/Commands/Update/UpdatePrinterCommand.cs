using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;

public class UpdatePrinterCommand : IRequest<UpdatedPrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PrinterOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPrinters";

    public UpdatePrinterDto Printer { get; set; }


    public class UpdatePrinterCommandHandler : IRequestHandler<UpdatePrinterCommand, UpdatedPrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePrinterCommandHandler(IPrinterRepository printerRepository, PrinterBusinessRules printerBusinessRules, IMapper mapper)
        {
            _printerRepository = printerRepository;
            _printerBusinessRules = printerBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPrinterResponse> Handle(UpdatePrinterCommand request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Printer.Id)
            .CheckCodeExistenceWhenUpdate(request.Printer.Code, request.Printer.Id);

            Printer? currentPrinter = await _printerRepository.GetAsync(predicate: x => x.Id == request.Printer.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Printer? printer = _mapper.Map(request.Printer, currentPrinter);
            printer.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedPrinterResponse>(await _printerRepository.UpdateAsync(printer));
        }
    }
}
