﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants.ShipmentAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;

public class UpdateShipmentAttributeValueCommand : IRequest<UpdatedShipmentAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentAttributes";

    public UpdateShipmentAttributeValueDto ShipmentAttributeValue { get; set; }


    public class UpdateShipmentAttributeValueCommandHandler : IRequestHandler<UpdateShipmentAttributeValueCommand, UpdatedShipmentAttributeValueResponse>
    {
        private readonly IShipmentAttributeValueRepository _shipmentAttributeValueRepository;
        private readonly ShipmentAttributeValueBusinessRules _shipmentAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateShipmentAttributeValueCommandHandler(IShipmentAttributeValueRepository shipmentAttributeValueRepository, ShipmentAttributeValueBusinessRules shipmentAttributeValueBusinessRules, IMapper mapper)
        {
            _shipmentAttributeValueRepository = shipmentAttributeValueRepository;
            _shipmentAttributeValueBusinessRules = shipmentAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedShipmentAttributeValueResponse> Handle(UpdateShipmentAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _shipmentAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ShipmentAttributeValue.Id)
            .CheckShipmentAttributeIdExistence(request.ShipmentAttributeValue.ShipmentAttributeId)
            .CheckShipmentIdExistence(request.ShipmentAttributeValue.ShipmentId);

            ShipmentAttributeValue? currentShipmentAttributeValue = await _shipmentAttributeValueRepository.GetAsync(predicate: x => x.Id == request.ShipmentAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ShipmentAttributeValue? shipmentAttributeValue = _mapper.Map(request.ShipmentAttributeValue, currentShipmentAttributeValue);
            shipmentAttributeValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedShipmentAttributeValueResponse>(await _shipmentAttributeValueRepository.UpdateAsync(shipmentAttributeValue));
        }
    }
}
