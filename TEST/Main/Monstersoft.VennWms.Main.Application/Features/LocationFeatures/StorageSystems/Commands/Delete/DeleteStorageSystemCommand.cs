using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Delete;

public class DeleteStorageSystemCommand : IRequest<DeletedStorageSystemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StorageSystemOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStorageSystems";

    public Guid Id { get; set; }


    public class DeleteStorageSystemCommandHandler : IRequestHandler<DeleteStorageSystemCommand, DeletedStorageSystemResponse>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;

        public DeleteStorageSystemCommandHandler(IStorageSystemRepository storageSystemRepository, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _storageSystemBusinessRules = storageSystemBusinessRules;
        }

        public async Task<DeletedStorageSystemResponse> Handle(DeleteStorageSystemCommand request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StorageSystem storageSystem = await _storageSystemRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _storageSystemRepository.DeleteAsync(storageSystem);

            return new DeletedStorageSystemResponse
            {
                Id = storageSystem.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StorageSystemMessages.RequestExecutedSuccessfully
            };
        }
    }
}

