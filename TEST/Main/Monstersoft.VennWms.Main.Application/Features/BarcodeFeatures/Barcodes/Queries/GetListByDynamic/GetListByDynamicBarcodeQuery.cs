using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
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


    public class GetListByDynamicBarcodeQueryHandler : IRequestHandler<GetListByDynamicBarcodeQuery, GetListResponse<GetListByDynamicBarcodeListItemDto>>
    {
        private readonly IBarcodeRepository _barcodeRepository;
        private readonly BarcodeBusinessRules _barcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBarcodeQueryHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules)
        {
            _barcodeRepository = barcodeRepository;
            _barcodeBusinessRules = barcodeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBarcodeListItemDto>> Handle(GetListByDynamicBarcodeQuery request, CancellationToken cancellationToken)
        {
            _barcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Barcode> barcodeList = await _barcodeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.BarcodeAreas).Include(m => m.BarcodePrinters),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicBarcodeListItemDto>>(barcodeList);
        }
    }

}

