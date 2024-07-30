using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants.PriorityListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Delete;

public class DeletePriorityListCommand : IRequest<DeletedPriorityListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, PriorityListOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetPriorityLists"];

    public int Id { get; set; }

    public class DeletePriorityListCommandHandler : IRequestHandler<DeletePriorityListCommand, DeletedPriorityListResponse>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;

        public DeletePriorityListCommandHandler(IPriorityListRepository priorityListRepository, PriorityListBusinessRules priorityListBusinessRules)
        {
            _priorityListRepository = priorityListRepository;
            _priorityListBusinessRules = priorityListBusinessRules;
        }

        public async Task<DeletedPriorityListResponse> Handle(DeletePriorityListCommand request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            PriorityList priorityList = await _priorityListRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _priorityListRepository.DeleteAsync(priorityList);

            return new DeletedPriorityListResponse
            {
                Id = priorityList.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = PriorityListMessages.RequestExecutedSuccessfully
            };
        }
    }
}



