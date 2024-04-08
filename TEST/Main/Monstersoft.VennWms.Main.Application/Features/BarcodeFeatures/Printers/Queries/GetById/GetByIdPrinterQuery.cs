using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants.PrinterOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetById;

public class GetByIdPrinterQuery : IRequest<GetByIdPrinterResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPrinterQueryHandler : IRequestHandler<GetByIdPrinterQuery, GetByIdPrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPrinterQueryHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _mapper = mapper;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<GetByIdPrinterResponse> Handle(GetByIdPrinterQuery request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPrinterResponse>(await _printerRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
