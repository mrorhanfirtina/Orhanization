using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants.PoAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetById;

public class GetByIdPoAttributeQuery : IRequest<GetByIdPoAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPoAttributeQueryHandler : IRequestHandler<GetByIdPoAttributeQuery, GetByIdPoAttributeResponse>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPoAttributeQueryHandler(IPoAttributeRepository poAttributeRepository, IMapper mapper, PoAttributeBusinessRules poAttributeBusinessRules)
        {
            _poAttributeRepository = poAttributeRepository;
            _mapper = mapper;
            _poAttributeBusinessRules = poAttributeBusinessRules;
        }

        public async Task<GetByIdPoAttributeResponse> Handle(GetByIdPoAttributeQuery request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPoAttributeResponse>(await _poAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

