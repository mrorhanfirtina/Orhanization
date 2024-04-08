using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;

public class CreateLocationProductAttributeCommand : IRequest<CreatedLocationProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductAttributes";

    public CreateLocationProductAttributeDto LocationProductAttribute { get; set; }


    public class CreateLocationProductAttributeCommandHandler : IRequestHandler<CreateLocationProductAttributeCommand, CreatedLocationProductAttributeResponse>
    {
        private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
        private readonly LocationProductAttributeBusinessRules _locationProductAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationProductAttributeCommandHandler(ILocationProductAttributeRepository locationProductAttributeRepository, IMapper mapper, LocationProductAttributeBusinessRules locationProductAttributeBusinessRules)
        {
            _locationProductAttributeRepository = locationProductAttributeRepository;
            _mapper = mapper;
            _locationProductAttributeBusinessRules = locationProductAttributeBusinessRules;
        }

        public async Task<CreatedLocationProductAttributeResponse> Handle(CreateLocationProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationProductAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckProductAttributeIdExistence(request.LocationProductAttribute.ProductAttributeId)
                .CheckLocationIdExistence(request.LocationProductAttribute.LocationId);

            LocationProductAttribute locationProductAttribute = _mapper.Map<LocationProductAttribute>(request.LocationProductAttribute);
            locationProductAttribute.Id = Guid.NewGuid();
            locationProductAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedLocationProductAttributeResponse>(await _locationProductAttributeRepository.AddAsync(locationProductAttribute));
        }
    }

}

