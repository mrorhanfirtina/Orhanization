using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants.PriorityListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetByCode;

public class GetByCodePriorityListQuery : IRequest<GetByCodePriorityListResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string Code { get; set; }
    public PriorityListDetailLevel DetailLevel { get; set; }

    public class GetByCodePriorityListQueryHandler : IRequestHandler<GetByCodePriorityListQuery, GetByCodePriorityListResponse>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodePriorityListQueryHandler(IPriorityListRepository priorityListRepository, IMapper mapper, PriorityListBusinessRules priorityListBusinessRules)
        {
            _priorityListRepository = priorityListRepository;
            _mapper = mapper;
            _priorityListBusinessRules = priorityListBusinessRules;
        }

        public async Task<GetByCodePriorityListResponse> Handle(GetByCodePriorityListQuery request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodePriorityListResponse>(await _priorityListRepository.GetAsync(
                    predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                    include: x =>
                    {
                        IQueryable<PriorityList> query = x;

                        var detailLevel = request.DetailLevel;

                        if (detailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.DepositorCompany);
                        }

                        var includableQuery = query as IIncludableQueryable<PriorityList, object>;
                        return includableQuery;
                    },
                    withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodePriorityListResponse>(await _priorityListRepository.GetAsync(
                    predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                    withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }

            
        }
    }
}



