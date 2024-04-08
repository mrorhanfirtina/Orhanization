using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Commands.Update;

public class UpdateLocationStockAttributeCommand : IRequest<UpdatedLocationStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationStockAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationStockAttributes";

    public UpdateLocationStockAttributeDto LocationStockAttribute { get; set; }


    public class UpdateLocationStockAttributeCommandHandler : IRequestHandler<UpdateLocationStockAttributeCommand, UpdatedLocationStockAttributeResponse>
    {
        private readonly ILocationStockAttributeRepository _locationStockAttributeRepository;
        private readonly LocationStockAttributeBusinessRules _locationStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationStockAttributeCommandHandler(ILocationStockAttributeRepository locationStockAttributeRepository, LocationStockAttributeBusinessRules locationStockAttributeBusinessRules, IMapper mapper)
        {
            _locationStockAttributeRepository = locationStockAttributeRepository;
            _locationStockAttributeBusinessRules = locationStockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationStockAttributeResponse> Handle(UpdateLocationStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationStockAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.LocationStockAttribute.Id)
            .CheckLocationIdExistence(request.LocationStockAttribute.LocationId)
            .CheckStockAttributeIdExistence(request.LocationStockAttribute.StockAttributeId);

            LocationStockAttribute? currentLocationStockAttribute = await _locationStockAttributeRepository.GetAsync(predicate: x => x.Id == request.LocationStockAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            LocationStockAttribute? locationStockAttribute = _mapper.Map(request.LocationStockAttribute, currentLocationStockAttribute);
            locationStockAttribute.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedLocationStockAttributeResponse>(await _locationStockAttributeRepository.UpdateAsync(locationStockAttribute));
        }
    }
}

