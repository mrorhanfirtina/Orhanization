using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants.PoTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetListByDynamic;

public class GetListByDynamicPoTypeQuery : IRequest<GetListResponse<GetListByDynamicPoTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public PoTypeDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicPoTypeQueryHandler : IRequestHandler<GetListByDynamicPoTypeQuery, GetListResponse<GetListByDynamicPoTypeListItemDto>>
    {
        private readonly IPoTypeRepository _poTypeRepository;
        private readonly PoTypeBusinessRules _poTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPoTypeQueryHandler(IPoTypeRepository poTypeRepository, IMapper mapper, PoTypeBusinessRules poTypeBusinessRules)
        {
            _poTypeRepository = poTypeRepository;
            _poTypeBusinessRules = poTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPoTypeListItemDto>> Handle(GetListByDynamicPoTypeQuery request, CancellationToken cancellationToken)
        {
            _poTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PoType> poTypeList = await _poTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<PoType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrders);
                    }

                    var includableQuery = query as IIncludableQueryable<PoType, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoTypeListItemDto>>(poTypeList);
            }
            else
            {
                Paginate<PoType> poTypeList = await _poTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoTypeListItemDto>>(poTypeList);
            }
        }
    }

}
