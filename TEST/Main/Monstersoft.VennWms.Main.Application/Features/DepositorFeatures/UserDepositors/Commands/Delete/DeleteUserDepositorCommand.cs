using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Delete;

public class DeleteUserDepositorCommand : IRequest<DeletedUserDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, UserDepositorOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUserDepositors"];

    public Guid Id { get; set; }


    public class DeleteUserDepositorCommandHandler : IRequestHandler<DeleteUserDepositorCommand, DeletedUserDepositorResponse>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;

        public DeleteUserDepositorCommandHandler(IUserDepositorRepository userDepositorRepository, UserDepositorBusinessRules userDepositorBusinessRules)
        {
            _userDepositorRepository = userDepositorRepository;
            _userDepositorBusinessRules = userDepositorBusinessRules;
        }

        public async Task<DeletedUserDepositorResponse> Handle(DeleteUserDepositorCommand request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            UserDepositor? userDepositor = await _userDepositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _userDepositorRepository.DeleteAsync(userDepositor);

            return new DeletedUserDepositorResponse
            {
                Id = userDepositor.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = userDepositor.DepositorId,
                IsSuccess = true,
                Message = UserDepositorMessages.RequestExecutedSuccessfully
            };
        }
    }

}

