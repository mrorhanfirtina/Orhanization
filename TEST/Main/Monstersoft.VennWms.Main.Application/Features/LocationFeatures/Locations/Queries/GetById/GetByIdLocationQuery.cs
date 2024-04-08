using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetById;

public class GetByIdLocationQuery : IRequest<GetByIdLocationResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdLocationQueryHandler : IRequestHandler<GetByIdLocationQuery, GetByIdLocationResponse>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationQueryHandler(ILocationRepository locationRepository, IMapper mapper, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
            _locationBusinessRules = locationBusinessRules;
        }

        public async Task<GetByIdLocationResponse> Handle(GetByIdLocationQuery request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdLocationResponse>(await _locationRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
