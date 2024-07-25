using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Delete;

public class DeleteUnsuitReasonCommand : IRequest<DeletedUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnsuitReasons"];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, UnsuitReasonOperationClaims.Delete];

    public Guid Id { get; set; }


    public class DeleteUnsuitReasonCommandHandler : IRequestHandler<DeleteUnsuitReasonCommand, DeletedUnsuitReasonResponse>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;

        public DeleteUnsuitReasonCommandHandler(IUnsuitReasonRepository unsuitReasonRepository, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
        }

        public async Task<DeletedUnsuitReasonResponse> Handle(DeleteUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            UnsuitReason unsuitReason = await _unsuitReasonRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _unsuitReasonRepository.DeleteAsync(unsuitReason);

            return new DeletedUnsuitReasonResponse
            {
                Id = unsuitReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = UnsuitReasonMessages.RequestExecutedSuccessfully
            };
        }
    }

}
