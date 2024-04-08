using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants.LocationProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetById;

public class GetByIdLocationProductAttributeQuery : IRequest<GetByIdLocationProductAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdLocationProductAttributeQueryHandler : IRequestHandler<GetByIdLocationProductAttributeQuery, GetByIdLocationProductAttributeResponse>
    {
        private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
        private readonly LocationProductAttributeBusinessRules _locationProductAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationProductAttributeQueryHandler(ILocationProductAttributeRepository locationProductAttributeRepository, IMapper mapper, LocationProductAttributeBusinessRules locationProductAttributeBusinessRules)
        {
            _locationProductAttributeRepository = locationProductAttributeRepository;
            _mapper = mapper;
            _locationProductAttributeBusinessRules = locationProductAttributeBusinessRules;
        }

        public async Task<GetByIdLocationProductAttributeResponse> Handle(GetByIdLocationProductAttributeQuery request, CancellationToken cancellationToken)
        {
            _locationProductAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdLocationProductAttributeResponse>(await _locationProductAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }


}

