using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants.LocationProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Update;

public class UpdateLocationProductAttributeCommand : IRequest<UpdatedLocationProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationProductAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductAttributes";

    public UpdateLocationProductAttributeDto LocationProductAttribute { get; set; }
    public LocationProductAttributesDetailLevel DetailLevel { get; set; }


    public class UpdateLocationProductAttributeCommandHandler : IRequestHandler<UpdateLocationProductAttributeCommand, UpdatedLocationProductAttributeResponse>
    {
        private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
        private readonly LocationProductAttributeBusinessRules _locationProductAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationProductAttributeCommandHandler(ILocationProductAttributeRepository locationProductAttributeRepository, LocationProductAttributeBusinessRules locationProductAttributeBusinessRules, IMapper mapper)
        {
            _locationProductAttributeRepository = locationProductAttributeRepository;
            _locationProductAttributeBusinessRules = locationProductAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationProductAttributeResponse> Handle(UpdateLocationProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _locationProductAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.LocationProductAttribute.Id)
            .CheckLocationIdExistence(request.LocationProductAttribute.LocationId)
            .CheckProductAttributeIdExistence(request.LocationProductAttribute.ProductAttributeId);

            LocationProductAttribute? currentLocationProductAttribute = await _locationProductAttributeRepository.GetAsync(predicate: x => x.Id == request.LocationProductAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            LocationProductAttribute? locationProductAttribute = _mapper.Map(request.LocationProductAttribute, currentLocationProductAttribute);
            locationProductAttribute.UpdatedDate = DateTime.Now;

            await _locationProductAttributeRepository.UpdateAsync(locationProductAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductAttributeRepository.GetAsync(predicate: x => x.Id == locationProductAttribute.Id,
                include: x =>
                {
                    IQueryable<LocationProductAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeProductAttribute)
                    {
                        query = query.Include(y => y.ProductAttribute);

                        if (detailLevel.ProductAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ProductAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<LocationProductAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductAttributeResponse>(response);
            }
            else
            {
                var response = await _locationProductAttributeRepository.GetAsync(predicate: x => x.Id == locationProductAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductAttributeResponse>(response);
            }
        }
    }
}

