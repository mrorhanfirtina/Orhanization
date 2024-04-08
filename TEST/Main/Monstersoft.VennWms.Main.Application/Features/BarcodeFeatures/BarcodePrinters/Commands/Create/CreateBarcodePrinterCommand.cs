using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;

public class CreateBarcodePrinterCommand : IRequest<CreatedBarcodePrinterResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodePrinters";

    public CreateBarcodePrinterDto BarcodePrinter { get; set; }


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

            return _mapper.Map<CreatedBarcodePrinterResponse>(await _barcodePrinterRepository.AddAsync(barcodePrinter));
        }
    }
}

