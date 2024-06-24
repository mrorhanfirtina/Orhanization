using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants.LocationUnitConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Queries.GetById;

public class GetByIdLocationUnitConstraintQuery : IRequest<GetByIdLocationUnitConstraintResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationUnitConstraintsDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationUnitConstraintQueryHandler : IRequestHandler<GetByIdLocationUnitConstraintQuery, GetByIdLocationUnitConstraintResponse>
    {
        private readonly ILocationUnitConstraintRepository _locationUnitConstraintRepository;
        private readonly LocationUnitConstraintBusinessRules _locationUnitConstraintBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationUnitConstraintQueryHandler(ILocationUnitConstraintRepository locationUnitConstraintRepository, IMapper mapper, LocationUnitConstraintBusinessRules locationUnitConstraintBusinessRules)
        {
            _locationUnitConstraintRepository = locationUnitConstraintRepository;
            _mapper = mapper;
            _locationUnitConstraintBusinessRules = locationUnitConstraintBusinessRules;
        }

        public async Task<GetByIdLocationUnitConstraintResponse> Handle(GetByIdLocationUnitConstraintQuery request, CancellationToken cancellationToken)
        {
            _locationUnitConstraintBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationUnitConstraintResponse>(await _locationUnitConstraintRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationUnitConstraintResponse>(await _locationUnitConstraintRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

