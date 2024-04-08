using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants.LocationProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Delete;

public class DeleteLocationProductAttributeCommand : IRequest<DeletedLocationProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LocationProductAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductAttributes";

    public Guid Id { get; set; }


    public class DeleteLocationProductAttributeCommandHandler : IRequestHandler<DeleteLocationProductAttributeCommand, DeletedLocationProductAttributeResponse>
    {
        private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
        private readonly LocationProductAttributeBusinessRules _locationProductAttributeBusinessRules;

        public DeleteLocationProductAttributeCommandHandler(ILocationProductAttributeRepository locationProductAttributeRepository, LocationProductAttributeBusinessRules locationProductAttributeBusinessRules)
        {
            _locationProductAttributeRepository = locationProductAttributeRepository;
            _locationProductAttributeBusinessRules = locationProductAttributeBusinessRules;
        }

        public async Task<DeletedLocationProductAttributeResponse> Handle(DeleteLocationProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationProductAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductAttribute locationProductAttribute = await _locationProductAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationProductAttributeRepository.DeleteAsync(locationProductAttribute);

            return new DeletedLocationProductAttributeResponse
            {
                Id = locationProductAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationProductAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

