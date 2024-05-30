namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByDynamic;

using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;

using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;

public class GetListByDynamicDistributorQuery : IRequest<GetListResponse<GetListByDynamicDistributorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public DistributorsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicDisturbitorQueryHandler : IRequestHandler<GetListByDynamicDistributorQuery, GetListResponse<GetListByDynamicDistributorListItemDto>>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicDisturbitorQueryHandler(IDistributorRepository disturbitorRepository, IMapper mapper, DistributorBusinessRules disturbitorBusinessRules)
        {
            _disturbitorRepository = disturbitorRepository;
            _disturbitorBusinessRules = disturbitorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicDistributorListItemDto>> Handle(GetListByDynamicDistributorQuery request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Distributor> disturbitorList = await _disturbitorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Distributor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeBranch)
                    {
                        query = query.Include(y => y.Branches);
                    }


                    var includableQuery = query as IIncludableQueryable<Distributor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicDistributorListItemDto>>(disturbitorList);
            }
            else
            {
                Paginate<Distributor> disturbitorList = await _disturbitorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicDistributorListItemDto>>(disturbitorList);
            }
        }
    }
}
