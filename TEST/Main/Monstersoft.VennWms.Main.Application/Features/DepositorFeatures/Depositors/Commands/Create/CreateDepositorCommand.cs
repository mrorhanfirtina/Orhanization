using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;

public class CreateDepositorCommand : IRequest<CreatedDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositors";

    public CreateDepositorDto Depositor { get; set; }


    public class CreateDepositorCommandHandler : IRequestHandler<CreateDepositorCommand, CreatedDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateDepositorCommandHandler(IDepositorRepository depositorRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _mapper = mapper;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<CreatedDepositorResponse> Handle(CreateDepositorCommand request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Depositor.Code)
                .CheckDepositorCompanyIdExistence(request.Depositor.DepositorCompanyId);

            Depositor depositor = _mapper.Map<Depositor>(request.Depositor);
            depositor.Id = Guid.NewGuid();
            depositor.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            depositor.CreatedDate = DateTime.Now;
            depositor.DepositorFeature.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedDepositorResponse>(await _depositorRepository.AddAsync(depositor));
        }
    }

}
