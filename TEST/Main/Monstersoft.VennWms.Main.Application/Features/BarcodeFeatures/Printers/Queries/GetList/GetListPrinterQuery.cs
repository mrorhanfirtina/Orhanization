using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants.PrinterOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetList;

public class GetListPrinterQuery : IRequest<GetListResponse<GetListPrinterListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListPrinterQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetPrinters";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListPrinterQueryHandler : IRequestHandler<GetListPrinterQuery, GetListResponse<GetListPrinterListItemDto>>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public GetListPrinterQueryHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _mapper = mapper;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<GetListResponse<GetListPrinterListItemDto>> Handle(GetListPrinterQuery request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Printer> printerList = await _printerRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListPrinterListItemDto>>(printerList);
        }
    }
}
