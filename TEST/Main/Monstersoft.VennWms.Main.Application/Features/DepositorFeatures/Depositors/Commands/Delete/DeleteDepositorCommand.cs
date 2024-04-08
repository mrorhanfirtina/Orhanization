using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Delete;

public class DeleteDepositorCommand : IRequest<DeletedDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, DepositorOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositors";

    public Guid Id { get; set; }


    public class DeleteDepositorCommandHandler : IRequestHandler<DeleteDepositorCommand, DeletedDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;

        public DeleteDepositorCommandHandler(IDepositorRepository depositorRepository, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<DeletedDepositorResponse> Handle(DeleteDepositorCommand request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Depositor depositor = await _depositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _depositorRepository.DeleteAsync(depositor, permanent: true);

            return new DeletedDepositorResponse
            {
                Id = depositor.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = DepositorMessages.RequestExecutedSuccessfully
            };
        }
    }
}
