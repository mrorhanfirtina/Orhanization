using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants.LocationUnitConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Update;

public class UpdateLocationUnitConstraintCommand : IRequest<UpdatedLocationUnitConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationUnitConstraintOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationUnitConstraints";

    public UpdateLocationUnitConstraintDto LocationUnitConstraint { get; set; }
    public LocationUnitConstraintDetailLevel DetailLevel { get; set; }

    public class UpdateLocationUnitConstraintCommandHandler : IRequestHandler<UpdateLocationUnitConstraintCommand, UpdatedLocationUnitConstraintResponse>
    {
        private readonly ILocationUnitConstraintRepository _locationUnitConstraintRepository;
        private readonly LocationUnitConstraintBusinessRules _locationUnitConstraintBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationUnitConstraintCommandHandler(ILocationUnitConstraintRepository locationUnitConstraintRepository, LocationUnitConstraintBusinessRules locationUnitConstraintBusinessRules, IMapper mapper)
        {
            _locationUnitConstraintRepository = locationUnitConstraintRepository;
            _locationUnitConstraintBusinessRules = locationUnitConstraintBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationUnitConstraintResponse> Handle(UpdateLocationUnitConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationUnitConstraintBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationUnitConstraint? currentLocationUnitConstraint = await _locationUnitConstraintRepository.GetAsync(predicate: x => x.Id == request.LocationUnitConstraint.Id);

            LocationUnitConstraint? locationUnitConstraint = _mapper.Map(request.LocationUnitConstraint, currentLocationUnitConstraint);
            locationUnitConstraint.UpdatedDate = DateTime.Now;

            await _locationUnitConstraintRepository.UpdateAsync(locationUnitConstraint);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationUnitConstraintRepository.GetAsync(predicate: x => x.Id == locationUnitConstraint.Id,
                include: x =>
                {
                    IQueryable<LocationUnitConstraint> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeUnit)
                    {
                        query = query.Include(y => y.Unit);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationUnitConstraint, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationUnitConstraintResponse>(response);
            }
            else
            {
                var response = await _locationUnitConstraintRepository.GetAsync(predicate: x => x.Id == locationUnitConstraint.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationUnitConstraintResponse>(response);
            }
        }
    }
}

