using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Create;

public class CreateLocationStockAttributeCommand : IRequest<CreatedLocationStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationStockAttributes";

    public CreateLocationStockAttributeDto LocationStockAttribute { get; set; }


    public class CreateLocationStockAttributeCommandHandler : IRequestHandler<CreateLocationStockAttributeCommand, CreatedLocationStockAttributeResponse>
    {
        private readonly ILocationStockAttributeRepository _locationStockAttributeRepository;
        private readonly LocationStockAttributeBusinessRules _locationStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationStockAttributeCommandHandler(ILocationStockAttributeRepository locationStockAttributeRepository, IMapper mapper, LocationStockAttributeBusinessRules locationStockAttributeBusinessRules)
        {
            _locationStockAttributeRepository = locationStockAttributeRepository;
            _mapper = mapper;
            _locationStockAttributeBusinessRules = locationStockAttributeBusinessRules;
        }

        public async Task<CreatedLocationStockAttributeResponse> Handle(CreateLocationStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationStockAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckLocationIdExistence(request.LocationStockAttribute.LocationId)
                .CheckStockAttributeIdExistence(request.LocationStockAttribute.StockAttributeId);

            LocationStockAttribute locationStockAttribute = _mapper.Map<LocationStockAttribute>(request.LocationStockAttribute);
            locationStockAttribute.Id = Guid.NewGuid();
            locationStockAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedLocationStockAttributeResponse>(await _locationStockAttributeRepository.AddAsync(locationStockAttribute));
        }
    }

}

