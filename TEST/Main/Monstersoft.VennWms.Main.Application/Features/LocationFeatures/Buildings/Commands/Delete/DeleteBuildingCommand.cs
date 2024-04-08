using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants.BuildingOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;

public class DeleteBuildingCommand : IRequest<DeletedBuildingResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, BuildingOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBuildings";

    public Guid Id { get; set; }


    public class DeleteBuildingCommandHandler : IRequestHandler<DeleteBuildingCommand, DeletedBuildingResponse>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;

        public DeleteBuildingCommandHandler(IBuildingRepository buildingRepository, BuildingBusinessRules buildingBusinessRules)
        {
            _buildingRepository = buildingRepository;
            _buildingBusinessRules = buildingBusinessRules;
        }

        public async Task<DeletedBuildingResponse> Handle(DeleteBuildingCommand request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Building building = await _buildingRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _buildingRepository.DeleteAsync(building);

            return new DeletedBuildingResponse
            {
                Id = building.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BuildingMessages.RequestExecutedSuccessfully
            };
        }
    }
}

