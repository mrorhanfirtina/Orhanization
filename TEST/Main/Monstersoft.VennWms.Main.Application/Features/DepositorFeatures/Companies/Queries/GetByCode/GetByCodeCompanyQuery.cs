using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants.CompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetByCode;

public class GetByCodeCompanyQuery : IRequest<GetByCodeCompanyResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeCompanyQueryHandler : IRequestHandler<GetByCodeCompanyQuery, GetByCodeCompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeCompanyQueryHandler(ICompanyRepository companyRepository, IMapper mapper, CompanyBusinessRules companyBusinessRules)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _companyBusinessRules = companyBusinessRules;
        }

        public async Task<GetByCodeCompanyResponse> Handle(GetByCodeCompanyQuery request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeCompanyResponse>(await _companyRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }
}
