using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants.SiteOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetByCode;

public class GetByCodeSiteQuery : IRequest<GetByCodeSiteResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeSiteQueryHandler : IRequestHandler<GetByCodeSiteQuery, GetByCodeSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeSiteQueryHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<GetByCodeSiteResponse> Handle(GetByCodeSiteQuery request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeSiteResponse>(await _siteRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(y => y.SiteDepositors),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

