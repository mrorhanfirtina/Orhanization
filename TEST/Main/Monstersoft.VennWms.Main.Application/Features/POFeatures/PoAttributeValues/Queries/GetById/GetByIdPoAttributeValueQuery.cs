using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetById;

public class GetByIdPoAttributeValueQuery : IRequest<GetByIdPoAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPoAttributeValueQueryHandler : IRequestHandler<GetByIdPoAttributeValueQuery, GetByIdPoAttributeValueResponse>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPoAttributeValueQueryHandler(IPoAttributeValueRepository poAttributeValueRepository, IMapper mapper, PoAttributeValueBusinessRules poAttributeValueBusinessRules)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _mapper = mapper;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
        }

        public async Task<GetByIdPoAttributeValueResponse> Handle(GetByIdPoAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPoAttributeValueResponse>(await _poAttributeValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

