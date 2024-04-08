using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByCode;

public class GetByCodeDistributorQuery : IRequest<GetByCodeDistributorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeDisturbitorQueryHandler : IRequestHandler<GetByCodeDistributorQuery, GetByCodeDistributorResponse>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeDisturbitorQueryHandler(IDistributorRepository disturbitorRepository, IMapper mapper, DistributorBusinessRules disturbitorBusinessRules)
        {
            _disturbitorRepository = disturbitorRepository;
            _mapper = mapper;
            _disturbitorBusinessRules = disturbitorBusinessRules;
        }

        public async Task<GetByCodeDistributorResponse> Handle(GetByCodeDistributorQuery request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeDistributorResponse>(await _disturbitorRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

