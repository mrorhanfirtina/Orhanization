using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetById;

public class GetByIdOrderItemQuery : IRequest<GetByIdOrderItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderItemQueryHandler : IRequestHandler<GetByIdOrderItemQuery, GetByIdOrderItemResponse>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
            _orderItemBusinessRules = orderItemBusinessRules;
        }

        public async Task<GetByIdOrderItemResponse> Handle(GetByIdOrderItemQuery request, CancellationToken cancellationToken)
        {
            _orderItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderItemResponse>(await _orderItemRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.OrderItemMemos).Include(x => x.OrderItemStockAttrValues),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
