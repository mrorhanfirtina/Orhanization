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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetById;

public class GetByIdCompanyQuery : IRequest<GetByIdCompanyResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdCompanyQueryHandler : IRequestHandler<GetByIdCompanyQuery, GetByIdCompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdCompanyQueryHandler(ICompanyRepository companyRepository, IMapper mapper, CompanyBusinessRules companyBusinessRules)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _companyBusinessRules = companyBusinessRules;
        }

        public async Task<GetByIdCompanyResponse> Handle(GetByIdCompanyQuery request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdCompanyResponse>(await _companyRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(m => m.Address),
                withDeleted: false, 
                cancellationToken: cancellationToken));
        }
    }

}
