using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants.LocationZoneOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetById;

public class GetByIdLocationZoneQuery : IRequest<GetByIdLocationZoneResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationZonesDetailLevel DetailLevel { get; set; }


    public class GetByIdLocationZoneQueryHandler : IRequestHandler<GetByIdLocationZoneQuery, GetByIdLocationZoneResponse>
    {
        private readonly ILocationZoneRepository _locationZoneRepository;
        private readonly LocationZoneBusinessRules _locationZoneBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationZoneQueryHandler(ILocationZoneRepository locationZoneRepository, IMapper mapper, LocationZoneBusinessRules locationZoneBusinessRules)
        {
            _locationZoneRepository = locationZoneRepository;
            _mapper = mapper;
            _locationZoneBusinessRules = locationZoneBusinessRules;
        }

        public async Task<GetByIdLocationZoneResponse> Handle(GetByIdLocationZoneQuery request, CancellationToken cancellationToken)
        {
            _locationZoneBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationZoneResponse>(await _locationZoneRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<LocationZone> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeZone)
                    {
                        query = query.Include(y => y.Zone);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationZone, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationZoneResponse>(await _locationZoneRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

