using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetByCode;

public class GetByCodeDepositorCompanyQuery : IRequest<GetByCodeDepositorCompanyResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeDepositorCompanyQueryHandler : IRequestHandler<GetByCodeDepositorCompanyQuery, GetByCodeDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeDepositorCompanyQueryHandler(IDepositorCompanyRepository depositorCompanyRepository, IMapper mapper, DepositorCompanyBusinessRules depositorCompanyBusinessRules)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _mapper = mapper;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
        }

        public async Task<GetByCodeDepositorCompanyResponse> Handle(GetByCodeDepositorCompanyQuery request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeDepositorCompanyResponse>(await _depositorCompanyRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.Id == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
