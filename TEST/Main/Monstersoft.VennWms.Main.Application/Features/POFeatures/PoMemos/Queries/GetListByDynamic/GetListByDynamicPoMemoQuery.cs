using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants.PoMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetListByDynamic;

public class GetListByDynamicPoMemoQuery : IRequest<GetListResponse<GetListByDynamicPoMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public PoMemosDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicPoMemoQueryHandler : IRequestHandler<GetListByDynamicPoMemoQuery, GetListResponse<GetListByDynamicPoMemoListItemDto>>
    {
        private readonly IPoMemoRepository _poMemoRepository;
        private readonly PoMemoBusinessRules _poMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPoMemoQueryHandler(IPoMemoRepository poMemoRepository, IMapper mapper, PoMemoBusinessRules poMemoBusinessRules)
        {
            _poMemoRepository = poMemoRepository;
            _poMemoBusinessRules = poMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPoMemoListItemDto>> Handle(GetListByDynamicPoMemoQuery request, CancellationToken cancellationToken)
        {
            _poMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PoMemo> poMemoList = await _poMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<PoMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrder);
                    }


                    var includableQuery = query as IIncludableQueryable<PoMemo, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoMemoListItemDto>>(poMemoList);
            }
            else
            {
                Paginate<PoMemo> poMemoList = await _poMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoMemoListItemDto>>(poMemoList);
            }
        }
    }

}
