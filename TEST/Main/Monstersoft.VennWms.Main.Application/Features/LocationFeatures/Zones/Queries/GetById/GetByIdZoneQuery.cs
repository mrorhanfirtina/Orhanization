using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants.ZoneOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetById;

public class GetByIdZoneQuery : IRequest<GetByIdZoneResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


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

            return _mapper.Map<GetByIdZoneResponse>(await _zoneRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

