using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants.BarcodeAreaOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetListByDynamic;

public class GetListByDynamicBarcodeAreaQuery : IRequest<GetListResponse<GetListByDynamicBarcodeAreaListItemDto>>, ITransactionalRequest,
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, BarcodeAreaOperationClaims.User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public BarcodeAreasDetailLevel? DetailLevel { get; set; }

    public class GetListByDynamicBarcodeAreaQueryHandler : IRequestHandler<GetListByDynamicBarcodeAreaQuery, GetListResponse<GetListByDynamicBarcodeAreaListItemDto>>
    {
        private readonly IBarcodeAreaRepository _barcodeAreaRepository;
        private readonly BarcodeAreaBusinessRules _barcodeAreaBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBarcodeAreaQueryHandler(IBarcodeAreaRepository barcodeAreaRepository, IMapper mapper, BarcodeAreaBusinessRules barcodeAreaBusinessRules)
        {
            _barcodeAreaRepository = barcodeAreaRepository;
            _barcodeAreaBusinessRules = barcodeAreaBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBarcodeAreaListItemDto>> Handle(GetListByDynamicBarcodeAreaQuery request, CancellationToken cancellationToken)
        {
            _barcodeAreaBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);



            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<BarcodeArea> barcodeAreaList = await _barcodeAreaRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                enableTracking: false,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                include: x =>
                {
                    IQueryable<BarcodeArea> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeBarcode)
                    {
                        query = query.Include(y => y.Barcode);

                        if (detailLevel.BarcodeDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Barcode).ThenInclude(m => m.DepositorCompany);
                        }
                    }
                    var includableQuery = query as IIncludableQueryable<BarcodeArea, object>;

                    return includableQuery;

                }
                );

                return _mapper.Map<GetListResponse<GetListByDynamicBarcodeAreaListItemDto>>(barcodeAreaList);
            }
            else
            {
                Paginate<BarcodeArea> barcodeAreaList = await _barcodeAreaRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                enableTracking: false,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBarcodeAreaListItemDto>>(barcodeAreaList);
            }
        }
    }


}
