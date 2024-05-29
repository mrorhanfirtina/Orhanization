using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants.LocationProductConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Queries.GetById;

public class GetByIdLocationProductConstraintQuery : IRequest<GetByIdLocationProductConstraintResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationProductConstraintDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationProductConstraintQueryHandler : IRequestHandler<GetByIdLocationProductConstraintQuery, GetByIdLocationProductConstraintResponse>
    {
        private readonly ILocationProductConstraintRepository _locationProductConstraintRepository;
        private readonly LocationProductConstraintBusinessRules _locationProductConstraintBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationProductConstraintQueryHandler(ILocationProductConstraintRepository locationProductConstraintRepository, IMapper mapper, LocationProductConstraintBusinessRules locationProductConstraintBusinessRules)
        {
            _locationProductConstraintRepository = locationProductConstraintRepository;
            _mapper = mapper;
            _locationProductConstraintBusinessRules = locationProductConstraintBusinessRules;
        }

        public async Task<GetByIdLocationProductConstraintResponse> Handle(GetByIdLocationProductConstraintQuery request, CancellationToken cancellationToken)
        {
            _locationProductConstraintBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationProductConstraintResponse>(await _locationProductConstraintRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationProductConstraintResponse>(await _locationProductConstraintRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

