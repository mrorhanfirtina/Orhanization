using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants.LocationStockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Delete;

public class DeleteLocationStockAttributeCommand : IRequest<DeletedLocationStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LocationStockAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationStockAttributes";

    public Guid Id { get; set; }


    public class DeleteLocationStockAttributeCommandHandler : IRequestHandler<DeleteLocationStockAttributeCommand, DeletedLocationStockAttributeResponse>
    {
        private readonly ILocationStockAttributeRepository _locationStockAttributeRepository;
        private readonly LocationStockAttributeBusinessRules _locationStockAttributeBusinessRules;

        public DeleteLocationStockAttributeCommandHandler(ILocationStockAttributeRepository locationStockAttributeRepository, LocationStockAttributeBusinessRules locationStockAttributeBusinessRules)
        {
            _locationStockAttributeRepository = locationStockAttributeRepository;
            _locationStockAttributeBusinessRules = locationStockAttributeBusinessRules;
        }

        public async Task<DeletedLocationStockAttributeResponse> Handle(DeleteLocationStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationStockAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationStockAttribute locationStockAttribute = await _locationStockAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationStockAttributeRepository.DeleteAsync(locationStockAttribute);

            return new DeletedLocationStockAttributeResponse
            {
                Id = locationStockAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationStockAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }

}

