using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants.ReturnMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetById;

public class GetByIdReturnMemoQuery : IRequest<GetByIdReturnMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnMemoQueryHandler : IRequestHandler<GetByIdReturnMemoQuery, GetByIdReturnMemoResponse>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnMemoQueryHandler(IReturnMemoRepository returnMemoRepository, IMapper mapper, ReturnMemoBusinessRules returnMemoBusinessRules)
        {
            _returnMemoRepository = returnMemoRepository;
            _mapper = mapper;
            _returnMemoBusinessRules = returnMemoBusinessRules;
        }

        public async Task<GetByIdReturnMemoResponse> Handle(GetByIdReturnMemoQuery request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnMemoResponse>(await _returnMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
