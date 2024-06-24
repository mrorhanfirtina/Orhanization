using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;

public class CreateShipmentAttributeCommand : IRequest<CreatedShipmentAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentAttributes";

    public CreateShipmentAttributeDto ShipmentAttribute { get; set; }
    public ShipmentAttributesDetailLevel? DetailLevel { get; set; }


    public class CreateShipmentAttributeCommandHandler : IRequestHandler<CreateShipmentAttributeCommand, CreatedShipmentAttributeResponse>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateShipmentAttributeCommandHandler(IShipmentAttributeRepository shipmentAttributeRepository, IMapper mapper, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _mapper = mapper;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
        }

        public async Task<CreatedShipmentAttributeResponse> Handle(CreateShipmentAttributeCommand request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ShipmentAttribute.Code)
                .CheckAttributeInputTypeIdExistence(request.ShipmentAttribute.AttributeInputTypeId);

            ShipmentAttribute shipmentAttribute = _mapper.Map<ShipmentAttribute>(request.ShipmentAttribute);
            shipmentAttribute.Id = Guid.NewGuid();
            shipmentAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            shipmentAttribute.CreatedDate = DateTime.Now;

            await _shipmentAttributeRepository.AddAsync(shipmentAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _shipmentAttributeRepository.GetAsync(predicate: x => x.Id == shipmentAttribute.Id,
                include: x =>
                {
                    IQueryable<ShipmentAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    var includableQuery = query as IIncludableQueryable<ShipmentAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentAttributeResponse>(response);
            }
            else
            {
                var response = await _shipmentAttributeRepository.GetAsync(predicate: x => x.Id == shipmentAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentAttributeResponse>(response);
            }
        }
    }
}
