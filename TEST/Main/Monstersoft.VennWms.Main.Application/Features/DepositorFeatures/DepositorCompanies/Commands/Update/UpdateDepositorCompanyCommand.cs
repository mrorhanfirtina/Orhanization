using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;

public class UpdateDepositorCompanyCommand : IRequest<UpdatedDepositorCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, DepositorCompanyOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositorCompanies";

    public UpdateDepositorCompanyDto DepositorCompany { get; set; }


    public class UpdateDepositorCompanyCommandHandler : IRequestHandler<UpdateDepositorCompanyCommand, UpdatedDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateDepositorCompanyCommandHandler(IDepositorCompanyRepository depositorCompanyRepository, DepositorCompanyBusinessRules depositorCompanyBusinessRules, IMapper mapper)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedDepositorCompanyResponse> Handle(UpdateDepositorCompanyCommand request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.UpdateRequest().CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            DepositorCompany? currentDepositorCompany = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == request.DepositorCompany.Id,
                include: x => x.Include(y => y.Address));

            DepositorCompany? depositorCompany = _mapper.Map(request.DepositorCompany, currentDepositorCompany);
            depositorCompany.UpdatedDate = DateTime.Now;
            depositorCompany.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedDepositorCompanyResponse>(await _depositorCompanyRepository.UpdateAsync(depositorCompany));
        }
    }
}
