using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetById;

public class GetByIdShipmentAttributeValueQuery : IRequest<GetByIdShipmentAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ShipmentAttributesValueDetailLevel? DetailLevel { get; set; }


    public class GetByIdShipmentAttributeValueQueryHandler : IRequestHandler<GetByIdShipmentAttributeValueQuery, GetByIdShipmentAttributeValueResponse>
    {
        private readonly IShipmentAttributeValueRepository _shipmentAttributeValueRepository;
        private readonly ShipmentAttributeValueBusinessRules _shipmentAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentAttributeValueQueryHandler(IShipmentAttributeValueRepository shipmentAttributeValueRepository, IMapper mapper, ShipmentAttributeValueBusinessRules shipmentAttributeValueBusinessRules)
        {
            _shipmentAttributeValueRepository = shipmentAttributeValueRepository;
            _mapper = mapper;
            _shipmentAttributeValueBusinessRules = shipmentAttributeValueBusinessRules;
        }

        public async Task<GetByIdShipmentAttributeValueResponse> Handle(GetByIdShipmentAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdShipmentAttributeValueResponse>(await _shipmentAttributeValueRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdShipmentAttributeValueResponse>(await _shipmentAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
