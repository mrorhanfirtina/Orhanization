using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Commands.Update;

public class UpdateShipmentAttributeCommand : IRequest<UpdatedShipmentAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentAttributes";

    public UpdateShipmentAttributeDto ShipmentAttribute { get; set; }
    public ShipmentAttributesDetailLevel? DetailLevel { get; set; }


    public class UpdateShipmentAttributeCommandHandler : IRequestHandler<UpdateShipmentAttributeCommand, UpdatedShipmentAttributeResponse>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateShipmentAttributeCommandHandler(IShipmentAttributeRepository shipmentAttributeRepository, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules, IMapper mapper)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedShipmentAttributeResponse> Handle(UpdateShipmentAttributeCommand request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ShipmentAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.ShipmentAttribute.AttributeInputTypeId)
            .CheckCodeExistenceWhenUpdate(request.ShipmentAttribute.Code, request.ShipmentAttribute.Id);

            ShipmentAttribute? currentShipmentAttribute = await _shipmentAttributeRepository.GetAsync(predicate: x => x.Id == request.ShipmentAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ShipmentAttribute? shipmentAttribute = _mapper.Map(request.ShipmentAttribute, currentShipmentAttribute);
            shipmentAttribute.UpdatedDate = DateTime.Now;

            await _shipmentAttributeRepository.UpdateAsync(shipmentAttribute);

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

                return _mapper.Map<UpdatedShipmentAttributeResponse>(response);
            }
            else
            {
                var response = await _shipmentAttributeRepository.GetAsync(predicate: x => x.Id == shipmentAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedShipmentAttributeResponse>(response);
            }
        }
    }
}
