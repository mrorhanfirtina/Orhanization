﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants.ShipmentMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Update;

public class UpdateShipmentMemoCommand : IRequest<UpdatedShipmentMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetShipmentMemos";

    public UpdateShipmentMemoDto ShipmentMemo { get; set; }

    public class UpdateShipmentMemoCommandHandler : IRequestHandler<UpdateShipmentMemoCommand, UpdatedShipmentMemoResponse>
    {
        private readonly IShipmentMemoRepository _shipmentMemoRepository;
        private readonly ShipmentMemoBusinessRules _shipmentMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateShipmentMemoCommandHandler(IShipmentMemoRepository shipmentMemoRepository, ShipmentMemoBusinessRules shipmentMemoBusinessRules, IMapper mapper)
        {
            _shipmentMemoRepository = shipmentMemoRepository;
            _shipmentMemoBusinessRules = shipmentMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedShipmentMemoResponse> Handle(UpdateShipmentMemoCommand request, CancellationToken cancellationToken)
        {
            _shipmentMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ShipmentMemo.Id)
            .CheckShipmentIdExistence(request.ShipmentMemo.ShipmentId);

            ShipmentMemo? currentShipmentMemo = await _shipmentMemoRepository.GetAsync(predicate: x => x.Id == request.ShipmentMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ShipmentMemo? shipmentMemo = _mapper.Map(request.ShipmentMemo, currentShipmentMemo);
            shipmentMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedShipmentMemoResponse>(await _shipmentMemoRepository.UpdateAsync(shipmentMemo));
        }
    }
}
