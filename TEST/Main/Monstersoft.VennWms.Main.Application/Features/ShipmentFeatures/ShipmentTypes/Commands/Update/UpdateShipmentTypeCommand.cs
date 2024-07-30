using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Update;

public class UpdateShipmentTypeCommand : IRequest<UpdatedShipmentTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ShipmentTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetShipmentTypes"];

    public UpdateShipmentTypeDto ShipmentType { get; set; }
    public ShipmentTypesDetailLevel? DetailLevel { get; set; }


    public class UpdateShipmentTypeCommandHandler : IRequestHandler<UpdateShipmentTypeCommand, UpdatedShipmentTypeResponse>
    {
        private readonly IShipmentTypeRepository _shipmentTypeRepository;
        private readonly IMapper _mapper;
        private readonly ShipmentTypeBusinessRules _shipmentTypeBusinessRules;

        public UpdateShipmentTypeCommandHandler(IShipmentTypeRepository shipmentTypeRepository, IMapper mapper, ShipmentTypeBusinessRules shipmentTypeBusinessRules)
        {
            _shipmentTypeRepository = shipmentTypeRepository;
            _mapper = mapper;
            _shipmentTypeBusinessRules = shipmentTypeBusinessRules;
        }

        public async Task<UpdatedShipmentTypeResponse> Handle(UpdateShipmentTypeCommand request, CancellationToken cancellationToken)
        {
            _shipmentTypeBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckIdExistence(request.ShipmentType.Id)
                .CheckCodeExistenceWhenUpdate(request.ShipmentType.Code, Guid.Parse(request.UserRequestInfo.RequestUserLocalityId));

            ShipmentType? currentShipmentType = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == request.ShipmentType.Id,
                           withDeleted: false, enableTracking: true, cancellationToken: cancellationToken);

            ShipmentType updatedShipmentType = _mapper.Map(request.ShipmentType, currentShipmentType);

            updatedShipmentType.UpdatedDate = DateTime.Now;

            await _shipmentTypeRepository.UpdateAsync(updatedShipmentType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == updatedShipmentType.Id,
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

                return _mapper.Map<UpdatedShipmentTypeResponse>(response);
            }
            else
            {
                var response = await _shipmentTypeRepository.GetAsync(predicate: x => x.Id == updatedShipmentType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedShipmentTypeResponse>(response);
            }
        }
    }
}

