using MediatR;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Delete;

public class DeleteExpectedSerialHierarchyCommand : IRequest<DeletedExpectedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest/*, ISecuredRequest*/
{
    //public string[] Roles => [Admin, User, ExpectedSerialHierarchyOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerialHierarchies"];

    public Guid Id { get; set; }


    public class DeleteExpectedSerialHierarchyCommandHandler : IRequestHandler<DeleteExpectedSerialHierarchyCommand, DeletedExpectedSerialHierarchyResponse>
    {
        private readonly IExpectedSerialHierarchyRepository _expectedSerialHierarchyRepository;
        private readonly ExpectedSerialHierarchyBusinessRules _expectedSerialHierarchyBusinessRules;

        public DeleteExpectedSerialHierarchyCommandHandler(IExpectedSerialHierarchyRepository expectedSerialHierarchyRepository, ExpectedSerialHierarchyBusinessRules expectedSerialHierarchyBusinessRules)
        {
            _expectedSerialHierarchyRepository = expectedSerialHierarchyRepository;
            _expectedSerialHierarchyBusinessRules = expectedSerialHierarchyBusinessRules;
        }

        public async Task<DeletedExpectedSerialHierarchyResponse> Handle(DeleteExpectedSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialHierarchyBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ExpectedSerialHierarchy expectedSerialHierarchy = await _expectedSerialHierarchyRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _expectedSerialHierarchyRepository.DeleteAsync(expectedSerialHierarchy);

            return new DeletedExpectedSerialHierarchyResponse
            {
                Id = expectedSerialHierarchy.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
