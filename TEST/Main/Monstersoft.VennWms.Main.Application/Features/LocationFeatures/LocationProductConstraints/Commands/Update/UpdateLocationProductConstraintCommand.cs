using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants.LocationProductConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Update;

public class UpdateLocationProductConstraintCommand : IRequest<UpdatedLocationProductConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductConstraintOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductConstraints";

    public UpdateLocationProductConstraintDto LocationProductConstraint { get; set; }
    public LocationProductConstraintDetailLevel DetailLevel { get; set; }

    public class UpdateLocationProductConstraintCommandHandler : IRequestHandler<UpdateLocationProductConstraintCommand, UpdatedLocationProductConstraintResponse>
    {
        private readonly ILocationProductConstraintRepository _locationProductConstraintRepository;
        private readonly LocationProductConstraintBusinessRules _locationProductConstraintBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationProductConstraintCommandHandler(ILocationProductConstraintRepository locationProductConstraintRepository, LocationProductConstraintBusinessRules locationProductConstraintBusinessRules, IMapper mapper)
        {
            _locationProductConstraintRepository = locationProductConstraintRepository;
            _locationProductConstraintBusinessRules = locationProductConstraintBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationProductConstraintResponse> Handle(UpdateLocationProductConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationProductConstraintBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductConstraint? currentLocationProductConstraint = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == request.LocationProductConstraint.Id);

            LocationProductConstraint? locationProductConstraint = _mapper.Map(request.LocationProductConstraint, currentLocationProductConstraint);
            locationProductConstraint.UpdatedDate = DateTime.Now;

            await _locationProductConstraintRepository.UpdateAsync(locationProductConstraint);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == locationProductConstraint.Id,
                include: x =>
                {
                    IQueryable<LocationProductConstraint> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProductConstraint, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductConstraintResponse>(response);
            }
            else
            {
                var response = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == locationProductConstraint.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductConstraintResponse>(response);
            }
        }
    }
}

