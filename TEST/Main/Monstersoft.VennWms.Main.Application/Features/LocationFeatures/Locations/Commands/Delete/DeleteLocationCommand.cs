﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Delete;

public class DeleteLocationCommand : IRequest<DeletedLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LocationOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocations";

    public Guid Id { get; set; }


    public class DeleteLocationCommandHandler : IRequestHandler<DeleteLocationCommand, DeletedLocationResponse>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;

        public DeleteLocationCommandHandler(ILocationRepository locationRepository, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _locationBusinessRules = locationBusinessRules;
        }

        public async Task<DeletedLocationResponse> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Location location = await _locationRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.LocationPickingType)
                .Include(y => y.LocationFeature).Include(y => y.LocationPriority).Include(y => y.LocationDimension)
                .Include(y => y.LocationCoordinate).Include(y => y.LocationCodeFormat).Include(y => y.LocationZones)
                .Include(y => y.LocationUnitConstraints).Include(y => y.LocationProductConstraints).Include(y => y.LocationDepositors)
                .Include(y => y.LocationStockAttributes).Include(y => y.LocationProductAttributes).Include(y => y.LocationProducts)
                .Include(y => y.LocationLockReason),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);


            await _locationRepository.DeleteAsync(location);

            return new DeletedLocationResponse
            {
                Id = location.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationMessages.RequestExecutedSuccessfully
            };
        }
    }
}
