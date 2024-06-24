using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicPoAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public PoAttributeValuesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicPoAttributeValueQueryHandler : IRequestHandler<GetListByDynamicPoAttributeValueQuery, GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPoAttributeValueQueryHandler(IPoAttributeValueRepository poAttributeValueRepository, IMapper mapper, PoAttributeValueBusinessRules poAttributeValueBusinessRules)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>> Handle(GetListByDynamicPoAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);



            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PoAttributeValue> poAttributeValueList = await _poAttributeValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<PoAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrder);
                    }

                    if (detailLevel.IncludePoAttribute)
                    {
                        query = query.Include(y => y.PoAttribute);

                        if (detailLevel.PoAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.PoAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<PoAttributeValue, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>(poAttributeValueList);
            }
            else
            {
                Paginate<PoAttributeValue> poAttributeValueList = await _poAttributeValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>(poAttributeValueList);
            }
        }
    }

}

