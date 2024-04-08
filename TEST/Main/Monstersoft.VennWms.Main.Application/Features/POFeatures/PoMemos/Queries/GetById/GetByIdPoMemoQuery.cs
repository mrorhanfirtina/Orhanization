using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants.PoMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Queries.GetById;

public class GetByIdPoMemoQuery : IRequest<GetByIdPoMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPoMemoQueryHandler : IRequestHandler<GetByIdPoMemoQuery, GetByIdPoMemoResponse>
    {
        private readonly IPoMemoRepository _poMemoRepository;
        private readonly PoMemoBusinessRules _poMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPoMemoQueryHandler(IPoMemoRepository poMemoRepository, IMapper mapper, PoMemoBusinessRules poMemoBusinessRules)
        {
            _poMemoRepository = poMemoRepository;
            _mapper = mapper;
            _poMemoBusinessRules = poMemoBusinessRules;
        }

        public async Task<GetByIdPoMemoResponse> Handle(GetByIdPoMemoQuery request, CancellationToken cancellationToken)
        {
            _poMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPoMemoResponse>(await _poMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
