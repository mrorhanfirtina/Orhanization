using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Create;

public class CreateDistributorCommand : IRequest<CreatedDistributorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDisturbitors";

    public CreateDistributorDto Disturbitor { get; set; }



    public class CreateDisturbitorCommandHandler : IRequestHandler<CreateDistributorCommand, CreatedDistributorResponse>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public CreateDisturbitorCommandHandler(IDistributorRepository disturbitorRepository, DistributorBusinessRules disturbitorBusinessRules, IMapper mapper)
        {
            _disturbitorRepository = disturbitorRepository;
            _disturbitorBusinessRules = disturbitorBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedDistributorResponse> Handle(CreateDistributorCommand request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.CreateRequest()
            .CheckCodeExistenceWhenCreate(request.Disturbitor.Code)
            .CheckCompanyIdExistence(request.Disturbitor.CompanyId);

            Distributor disturbitor = _mapper.Map<Distributor>(request.Disturbitor);
            disturbitor.Id = Guid.NewGuid();
            disturbitor.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            disturbitor.CreatedDate = DateTime.Now;
            disturbitor.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedDistributorResponse>(await _disturbitorRepository.AddAsync(disturbitor));
        }
    }
}

