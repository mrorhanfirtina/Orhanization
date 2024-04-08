using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants.UserDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;

public class CreateUserDepositorCommand : IRequest<CreatedUserDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUserDepositors";

    public CreateUserDepositorDto UserDepositor { get; set; }


    public class CreateUserDepositorCommandHandler : IRequestHandler<CreateUserDepositorCommand, CreatedUserDepositorResponse>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateUserDepositorCommandHandler(IUserDepositorRepository userDepositorRepository, IMapper mapper, UserDepositorBusinessRules userDepositorBusinessRules)
        {
            _userDepositorRepository = userDepositorRepository;
            _mapper = mapper;
            _userDepositorBusinessRules = userDepositorBusinessRules;
        }

        public async Task<CreatedUserDepositorResponse> Handle(CreateUserDepositorCommand request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckUserIdExistence(request.UserDepositor.UserId)
                .CheckDepositorIdExistence(request.UserDepositor.DepositorId);


            UserDepositor userDepositor = _mapper.Map<UserDepositor>(request.UserDepositor);
            userDepositor.Id = Guid.NewGuid();
            userDepositor.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedUserDepositorResponse>(await _userDepositorRepository.AddAsync(userDepositor));
        }
    }

}

