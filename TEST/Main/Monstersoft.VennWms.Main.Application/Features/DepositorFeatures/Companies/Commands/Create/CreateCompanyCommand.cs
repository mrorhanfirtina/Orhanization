using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants.CompanyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Create;

public class CreateCompanyCommand : IRequest<CreatedCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, Write, Add];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetCompanies";

    public CreateCompanyDto Company { get; set; }


    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreatedCompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public CreateCompanyCommandHandler(ICompanyRepository companyRepository, CompanyBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedCompanyResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.CreateRequest()
            .CheckCodeExistenceWhenCreate(request.Company.Code);

            Company company = _mapper.Map<Company>(request.Company);
            company.Id = Guid.NewGuid();
            company.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            company.CreatedDate = DateTime.Now;
            company.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedCompanyResponse>(await _companyRepository.AddAsync(company));
        }
    }
}
