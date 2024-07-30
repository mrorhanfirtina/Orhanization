using MediatR;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Delete;

public class DeleteSerialHierarchyCommand : IRequest<DeletedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest/*, ISecuredRequest*/
{
    //public string[] Roles => [Admin, User, SerialHierarchyOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerialHierarchies"];

    public Guid Id { get; set; }


    public class DeleteSerialHierarchyCommandHandler : IRequestHandler<DeleteSerialHierarchyCommand, DeletedSerialHierarchyResponse>
    {
        private readonly ISerialHierarchyRepository _serialHierarchyRepository;
        private readonly SerialHierarchyBusinessRules _serialHierarchyBusinessRules;

        public DeleteSerialHierarchyCommandHandler(ISerialHierarchyRepository serialHierarchyRepository, SerialHierarchyBusinessRules serialHierarchyBusinessRules)
        {
            _serialHierarchyRepository = serialHierarchyRepository;
            _serialHierarchyBusinessRules = serialHierarchyBusinessRules;
        }

        public async Task<DeletedSerialHierarchyResponse> Handle(DeleteSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _serialHierarchyBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            SerialHierarchy serialHierarchy = await _serialHierarchyRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _serialHierarchyRepository.DeleteAsync(serialHierarchy);

            return new DeletedSerialHierarchyResponse
            {
                Id = serialHierarchy.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
