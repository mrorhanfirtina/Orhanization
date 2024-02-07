using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetListByDynamic;

public class GetListByDynamicBarcodeQuery : IRequest<GetListResponse<GetListByDynamicBarcodeListItemDto>>, ITransactionalRequest, 
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
}

public class GetListByDynamicBarcodeQueryHandler : IRequestHandler<GetListByDynamicBarcodeQuery, GetListResponse<GetListByDynamicBarcodeListItemDto>>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly IMapper _mapper;

    public GetListByDynamicBarcodeQueryHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules, DepositorBusinessRules depositorBusinessRules)
    {
        _barcodeRepository = barcodeRepository;
        _mapper = mapper;
        _barcodeBusinessRules = barcodeBusinessRules;
        _depositorBusinessRules = depositorBusinessRules;
    }

    public async Task<GetListResponse<GetListByDynamicBarcodeListItemDto>> Handle(GetListByDynamicBarcodeQuery request, CancellationToken cancellationToken)
    {
        // User ile gelen token bilgisinden depositor id numarası çekilir.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

        // Depositor id gerçekten var mı ve aktif mi kontrol edilir.
        await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);
        // Depositorun herhangi bir barkodu var mı kontrol edilir.
        await _barcodeBusinessRules.IsDepositorHaveAnyBarcode(depositorId);

        // Depositorun barkodları çekilir.
        Paginate<Barcode> barcodes = await _barcodeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: m => m.Include(m => m.BarcodeAreas).Include(m => m.Printers),
                predicate: m => m.DepositorId == depositorId,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize);

        // Sonuç maplenip dönğlür.
        return _mapper.Map<GetListResponse<GetListByDynamicBarcodeListItemDto>>(barcodes);
    }
}
