using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants.LocationStockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetById;

public class GetByIdLocationStockAttributeQuery : IRequest<GetByIdLocationStockAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


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

            return _mapper.Map<GetByIdLocationZoneResponse>(await _locationZoneRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

