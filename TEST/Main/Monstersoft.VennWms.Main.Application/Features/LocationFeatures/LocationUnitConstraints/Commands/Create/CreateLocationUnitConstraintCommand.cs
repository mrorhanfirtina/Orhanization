using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Create;

public class CreateLocationUnitConstraintCommand : IRequest<CreatedLocationUnitConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationUnitConstraints";

    public CreateLocationUnitConstraintDto LocationUnitConstraint { get; set; }
    public LocationUnitConstraintDetailLevel DetailLevel { get; set; }


    public class CreateLocationUnitConstraintCommandHandler : IRequestHandler<CreateLocationUnitConstraintCommand, CreatedLocationUnitConstraintResponse>
    {
        private readonly ILocationUnitConstraintRepository _locationUnitConstraintRepository;
        private readonly LocationUnitConstraintBusinessRules _locationUnitConstraintBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationUnitConstraintCommandHandler(ILocationUnitConstraintRepository locationUnitConstraintRepository, IMapper mapper, LocationUnitConstraintBusinessRules locationUnitConstraintBusinessRules)
        {
            _locationUnitConstraintRepository = locationUnitConstraintRepository;
            _mapper = mapper;
            _locationUnitConstraintBusinessRules = locationUnitConstraintBusinessRules;
        }

        public async Task<CreatedLocationUnitConstraintResponse> Handle(CreateLocationUnitConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationUnitConstraintBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationUnitConstraint locationUnitConstraint = _mapper.Map<LocationUnitConstraint>(request.LocationUnitConstraint);
            locationUnitConstraint.Id = Guid.NewGuid();
            locationUnitConstraint.CreatedDate = DateTime.Now;

            await _locationUnitConstraintRepository.AddAsync(locationUnitConstraint);

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

                return _mapper.Map<CreatedLocationUnitConstraintResponse>(response);
            }
            else
            {
                var response = await _locationUnitConstraintRepository.GetAsync(predicate: x => x.Id == locationUnitConstraint.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationUnitConstraintResponse>(response);
            }
        }
    }
}

