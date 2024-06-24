using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants.BarcodePrinterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Delete;

public class DeleteBarcodePrinterCommand : IRequest<DeletedBarcodePrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, BarcodePrinterOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodes";

    public Guid Id { get; set; }


    public class DeleteBarcodePrinterCommandHandler : IRequestHandler<DeleteBarcodePrinterCommand, DeletedBarcodePrinterResponse>
    {
        private readonly IBarcodePrinterRepository _barcodePrinterRepository;
        private readonly BarcodePrinterBusinessRules _barcodePrinterBusinessRules;

        public DeleteBarcodePrinterCommandHandler(IBarcodePrinterRepository barcodePrinterRepository, BarcodePrinterBusinessRules barcodePrinterBusinessRules)
        {
            _barcodePrinterRepository = barcodePrinterRepository;
            _barcodePrinterBusinessRules = barcodePrinterBusinessRules;
        }

        public async Task<DeletedBarcodePrinterResponse> Handle(DeleteBarcodePrinterCommand request, CancellationToken cancellationToken)
        {
            _barcodePrinterBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            BarcodePrinter barcodePrinter = await _barcodePrinterRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _barcodePrinterRepository.DeleteAsync(barcodePrinter);

            return new DeletedBarcodePrinterResponse
            {
                Id = barcodePrinter.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BarcodePrinterMessages.RequestExecutedSuccessfully
            };
        }
    }
}
