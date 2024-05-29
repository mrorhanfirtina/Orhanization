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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetByCode;

public class GetByCodeDepositorQuery : IRequest<GetByCodeDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public DepositorDetailLevel DetailLevel { get; set; }


    public class GetByCodeDepositorQueryHandler : IRequestHandler<GetByCodeDepositorQuery, GetByCodeDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeDepositorQueryHandler(IDepositorRepository depositorRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _mapper = mapper;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<GetByCodeDepositorResponse> Handle(GetByCodeDepositorQuery request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeDepositorResponse>(await _depositorRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeDepositorResponse>(await _depositorRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
