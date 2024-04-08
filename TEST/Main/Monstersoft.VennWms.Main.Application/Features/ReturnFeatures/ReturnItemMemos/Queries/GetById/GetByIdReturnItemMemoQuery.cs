using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants.ReturnItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetById;

public class GetByIdReturnItemMemoQuery : IRequest<GetByIdReturnItemMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnItemMemoQueryHandler : IRequestHandler<GetByIdReturnItemMemoQuery, GetByIdReturnItemMemoResponse>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItemMemoQueryHandler(IReturnItemMemoRepository returnItemMemoRepository, IMapper mapper, ReturnItemMemoBusinessRules returnItemMemoBusinessRules)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _mapper = mapper;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
        }

        public async Task<GetByIdReturnItemMemoResponse> Handle(GetByIdReturnItemMemoQuery request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnItemMemoResponse>(await _returnItemMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

