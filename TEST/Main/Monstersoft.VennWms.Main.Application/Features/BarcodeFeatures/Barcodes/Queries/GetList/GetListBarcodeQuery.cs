using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetList;

public class GetListBarcodeQuery : IRequest<GetListResponse<GetListBarcodeListItemDto>>, ICachableRequest, 
    ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];
    public bool ByPassCache { get; }
    public TimeSpan? SlidingExpiration { get; }
    public string CacheKey => $"GetListBarcodeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetBarcodes";


    public PageRequest PageRequest { get; set; }


    public class GetListBarcodeQueryHandler : IRequestHandler<GetListBarcodeQuery, GetListResponse<GetListBarcodeListItemDto>>
    {
        private readonly IBarcodeRepository _barcodeRepository;
        private readonly BarcodeBusinessRules _barcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetListBarcodeQueryHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules)
        {
            _barcodeRepository = barcodeRepository;
            _mapper = mapper;
            _barcodeBusinessRules = barcodeBusinessRules;
        }

        public async Task<GetListResponse<GetListBarcodeListItemDto>> Handle(GetListBarcodeQuery request, CancellationToken cancellationToken)
        {
            _barcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Barcode> barcodeList = await _barcodeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(x => x.DepositorCompany)
                               .Include(i => i.BarcodeAreas)
                               .Include(i => i.BarcodePrinters)
                               .Include(x => x.BarcodePrinters).ThenInclude(m => m.Printer),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListBarcodeListItemDto>>(barcodeList);
        }
    }

}
