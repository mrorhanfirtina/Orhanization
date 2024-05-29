using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants.ZoneOperationClaims;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetById;

public class GetByIdZoneQuery : IRequest<GetByIdZoneResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ZoneDetailLevel DetailLevel { get; set; }


    public class GetByIdZoneQueryHandler : IRequestHandler<GetByIdZoneQuery, GetByIdZoneResponse>
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ZoneBusinessRules _zoneBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdZoneQueryHandler(IZoneRepository zoneRepository, IMapper mapper, ZoneBusinessRules zoneBusinessRules)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapper;
            _zoneBusinessRules = zoneBusinessRules;
        }

        public async Task<GetByIdZoneResponse> Handle(GetByIdZoneQuery request, CancellationToken cancellationToken)
        {
            _zoneBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdZoneResponse>(await _zoneRepository.GetAsync(x => x.Id == request.Id, withDeleted: false,
                include: x =>
                {
                    IQueryable<Zone> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeBuilding)
                    {
                        query = query.Include(y => y.Building);
                    }

                    var includableQuery = query as IIncludableQueryable<Zone, object>;
                    return includableQuery;
                },
                enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdZoneResponse>(await _zoneRepository.GetAsync(x => x.Id == request.Id, withDeleted: false,
                enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

