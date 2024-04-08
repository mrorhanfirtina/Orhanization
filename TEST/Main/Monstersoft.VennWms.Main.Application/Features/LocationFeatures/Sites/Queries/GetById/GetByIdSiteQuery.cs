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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetById;

public class GetByIdSiteQuery : IRequest<GetByIdSiteResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdSiteQueryHandler : IRequestHandler<GetByIdSiteQuery, GetByIdSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSiteQueryHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<GetByIdSiteResponse> Handle(GetByIdSiteQuery request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdSiteResponse>(await _siteRepository.GetAsync(x => x.Id == request.Id, include: x => x.Include(y => y.SiteDepositors), withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

