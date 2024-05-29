using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants.PoAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetList;

public class GetListPoAttributeQuery : IRequest<GetListResponse<GetListPoAttributeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListPoAttributeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetPoAttributes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public PoAttributeDetailLevel DetailLevel { get; set; }


    public class GetListPoAttributeQueryHandler : IRequestHandler<GetListPoAttributeQuery, GetListResponse<GetListPoAttributeListItemDto>>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListPoAttributeQueryHandler(IPoAttributeRepository poAttributeRepository, IMapper mapper, PoAttributeBusinessRules poAttributeBusinessRules)
        {
            _poAttributeRepository = poAttributeRepository;
            _mapper = mapper;
            _poAttributeBusinessRules = poAttributeBusinessRules;
        }

        public async Task<GetListResponse<GetListPoAttributeListItemDto>> Handle(GetListPoAttributeQuery request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<PoAttribute> poAttributeList = await _poAttributeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<PoAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<PoAttribute, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPoAttributeListItemDto>>(poAttributeList);
            }
            else
            {
                Paginate<PoAttribute> poAttributeList = await _poAttributeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListPoAttributeListItemDto>>(poAttributeList);
            }
        }
    }

}

