using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants.ShipmentTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Create;

public class CreateShipmentTypeCommand : IRequest<CreatedShipmentTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetShipmentTypes"];

    public CreateShipmentTypeDto ShipmentType { get; set; }
    public ShipmentTypesDetailLevel? DetailLevel { get; set; }


    public class CreateShipmentTypeCommandHandler : IRequestHandler<CreateShipmentTypeCommand, CreatedShipmentTypeResponse>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly IMapper _mapper;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;

        public CreateShipmentTypeCommandHandler(IShipmentTypeRepository shipmentTypeRepository, IMapper mapper, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _mapper = mapper;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<CreatedShipmentTypeResponse> Handle(CreateShipmentTypeCommand request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ShipmentType.Code);

            ShipmentType? shipmentTypeEntity = _mapper.Map<ShipmentType>(request.ShipmentType);

            shipmentTypeEntity.CreatedDate = DateTime.Now;
            shipmentTypeEntity.Id = Guid.NewGuid();
            shipmentTypeEntity.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            await _shipmentTypeRepository.AddAsync(shipmentTypeEntity);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == shipmentTypeEntity.Id,
                include: x =>
                {
                    IQueryable<ShipmentType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeShipment)
                    {
                        query = query.Include(y => y.Shipments);
                    }


                    var includableQuery = query as IIncludableQueryable<ShipmentType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentTypeResponse>(response);
            }
            else
            {
                var response = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == shipmentTypeEntity.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentTypeResponse>(response);
            }
        }
    }
}

