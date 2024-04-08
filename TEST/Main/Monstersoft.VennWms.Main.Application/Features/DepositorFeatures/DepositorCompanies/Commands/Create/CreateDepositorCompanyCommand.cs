using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;

public class CreateDepositorCompanyCommand : IRequest<CreatedDepositorCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositorCompanies";

    public CreateDepositorCompanyDto DepositorCompany { get; set; }


    public class CreateDepositorCompanyCommandHandler : IRequestHandler<CreateDepositorCompanyCommand, CreatedDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public CreateDepositorCompanyCommandHandler(IDepositorCompanyRepository depositorCompanyRepository, DepositorCompanyBusinessRules depositorCompanyBusinessRules, IMapper mapper)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedDepositorCompanyResponse> Handle(CreateDepositorCompanyCommand request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.CreateRequest().CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.DepositorCompany.Code);

            DepositorCompany depositorCompany = _mapper.Map<DepositorCompany>(request.DepositorCompany);
            depositorCompany.Id = Guid.NewGuid();
            depositorCompany.CreatedDate = DateTime.Now;
            depositorCompany.Address.CreatedDate = DateTime.Now;
            depositorCompany.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedDepositorCompanyResponse>(await _depositorCompanyRepository.AddAsync(depositorCompany));
        }
    }
}
