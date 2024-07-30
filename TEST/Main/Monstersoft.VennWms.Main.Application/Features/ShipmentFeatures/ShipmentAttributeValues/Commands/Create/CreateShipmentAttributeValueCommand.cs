using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants.ShipmentAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Create;

public class CreateShipmentAttributeValueCommand : IRequest<CreatedShipmentAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetShipmentAttributeValues"];


    public CreateShipmentAttributeValueDto ShipmentAttributeValue { get; set; }
    public ShipmentAttributesValueDetailLevel? DetailLevel { get; set; }


    public class CreateShipmentAttributeValueCommandHandler : IRequestHandler<CreateShipmentAttributeValueCommand, CreatedShipmentAttributeValueResponse>
    {
        private readonly IShipmentAttributeValueRepository _shipmentAttributeValueRepository;
        private readonly ShipmentAttributeValueBusinessRules _shipmentAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateShipmentAttributeValueCommandHandler(IShipmentAttributeValueRepository shipmentAttributeValueRepository, IMapper mapper, ShipmentAttributeValueBusinessRules shipmentAttributeValueBusinessRules)
        {
            _shipmentAttributeValueRepository = shipmentAttributeValueRepository;
            _mapper = mapper;
            _shipmentAttributeValueBusinessRules = shipmentAttributeValueBusinessRules;
        }

        public async Task<CreatedShipmentAttributeValueResponse> Handle(CreateShipmentAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _shipmentAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckShipmentAttributeIdExistence(request.ShipmentAttributeValue.ShipmentAttributeId)
                .CheckShipmentIdExistence(request.ShipmentAttributeValue.ShipmentId);

            ShipmentAttributeValue shipmentAttributeValue = _mapper.Map<ShipmentAttributeValue>(request.ShipmentAttributeValue);
            shipmentAttributeValue.Id = Guid.NewGuid();
            shipmentAttributeValue.CreatedDate = DateTime.Now;

            await _shipmentAttributeValueRepository.AddAsync(shipmentAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _shipmentAttributeValueRepository.GetAsync(predicate: x => x.Id == shipmentAttributeValue.Id,
                include: x =>
                {
                    IQueryable<ShipmentAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeShipment)
                    {
                        query = query.Include(y => y.Shipment);
                    }

                    if (detailLevel.IncludeShipmentAttribute)
                    {
                        query = query.Include(y => y.ShipmentAttribute);

                        if (detailLevel.ShipmentAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ShipmentAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ShipmentAttributeValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentAttributeValueResponse>(response);
            }
            else
            {
                var response = await _shipmentAttributeValueRepository.GetAsync(predicate: x => x.Id == shipmentAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentAttributeValueResponse>(response);
            }
        }
    }
}
