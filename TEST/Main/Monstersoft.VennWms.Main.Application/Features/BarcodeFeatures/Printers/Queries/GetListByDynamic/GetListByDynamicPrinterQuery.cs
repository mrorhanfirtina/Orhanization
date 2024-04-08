using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants.PrinterOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetListByDynamic;

public class GetListByDynamicPrinterQuery : IRequest<GetListResponse<GetListByDynamicPrinterListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicPrinterQueryHandler : IRequestHandler<GetListByDynamicPrinterQuery, GetListResponse<GetListByDynamicPrinterListItemDto>>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPrinterQueryHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _printerBusinessRules = printerBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPrinterListItemDto>> Handle(GetListByDynamicPrinterQuery request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Printer> printerList = await _printerRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicPrinterListItemDto>>(printerList);
        }
    }

}
