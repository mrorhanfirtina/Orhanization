using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetList;

public class GetListDepositorQuery : IRequest<GetListResponse<GetListDepositorListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListDepositorQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetDepositors";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public DepositorsDetailLevel DetailLevel { get; set; }


    public class GetListDepositorQueryHandler : IRequestHandler<GetListDepositorQuery, GetListResponse<GetListDepositorListItemDto>>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListDepositorQueryHandler(IDepositorRepository depositorRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _mapper = mapper;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<GetListResponse<GetListDepositorListItemDto>> Handle(GetListDepositorQuery request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Depositor> depositorList = await _depositorRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Depositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeDepositorFeature)
                    {
                        query = query.Include(y => y.DepositorFeature);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);

                        if (detailLevel.CompanyDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Company).ThenInclude(m => m.Address);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Depositor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListDepositorListItemDto>>(depositorList);
            }
            else
            {
                Paginate<Depositor> depositorList = await _depositorRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListDepositorListItemDto>>(depositorList);
            }
        }
    }

}
