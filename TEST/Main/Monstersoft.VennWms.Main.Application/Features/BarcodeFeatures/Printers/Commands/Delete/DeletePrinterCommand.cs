using MediatR;
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


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Delete;

public class DeletePrinterCommand : IRequest<DeletedPrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, PrinterOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPrinters";

    public Guid Id { get; set; }


    public class DeletePrinterCommandHandler : IRequestHandler<DeletePrinterCommand, DeletedPrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;

        public DeletePrinterCommandHandler(IPrinterRepository printerRepository, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<DeletedPrinterResponse> Handle(DeletePrinterCommand request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Printer printer = await _printerRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _printerRepository.DeleteAsync(printer);

            return new DeletedPrinterResponse
            {
                Id = printer.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = PrinterMessages.RequestExecutedSuccessfully
            };
        }
    }
}
