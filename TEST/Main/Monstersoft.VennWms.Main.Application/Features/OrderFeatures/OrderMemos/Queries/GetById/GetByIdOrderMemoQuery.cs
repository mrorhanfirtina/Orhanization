using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants.OrderMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetById;

public class GetByIdOrderMemoQuery : IRequest<GetByIdOrderMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderMemoQueryHandler : IRequestHandler<GetByIdOrderMemoQuery, GetByIdOrderMemoResponse>
    {
        private readonly IOrderMemoRepository _orderMemoRepository;
        private readonly OrderMemoBusinessRules _orderMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderMemoQueryHandler(IOrderMemoRepository orderMemoRepository, IMapper mapper, OrderMemoBusinessRules orderMemoBusinessRules)
        {
            _orderMemoRepository = orderMemoRepository;
            _mapper = mapper;
            _orderMemoBusinessRules = orderMemoBusinessRules;
        }

        public async Task<GetByIdOrderMemoResponse> Handle(GetByIdOrderMemoQuery request, CancellationToken cancellationToken)
        {
            _orderMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderMemoResponse>(await _orderMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

