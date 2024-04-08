using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants.OrderItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetById;

public class GetByIdOrderItemStockAttrValueQuery : IRequest<GetByIdOrderItemStockAttrValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderItemStockAttrValueQueryHandler : IRequestHandler<GetByIdOrderItemStockAttrValueQuery, GetByIdOrderItemStockAttrValueResponse>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderItemStockAttrValueQueryHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, IMapper mapper, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _mapper = mapper;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
        }

        public async Task<GetByIdOrderItemStockAttrValueResponse> Handle(GetByIdOrderItemStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderItemStockAttrValueResponse>(await _orderItemStockAttrValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
