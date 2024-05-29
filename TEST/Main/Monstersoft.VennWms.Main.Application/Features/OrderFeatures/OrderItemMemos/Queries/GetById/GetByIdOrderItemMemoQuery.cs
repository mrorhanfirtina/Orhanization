using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants.OrderItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetById;

public class GetByIdOrderItemMemoQuery : IRequest<GetByIdOrderItemMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderItemMemoDetailLevel DetailLevel { get; set; }


    public class GetByIdOrderItemMemoQueryHandler : IRequestHandler<GetByIdOrderItemMemoQuery, GetByIdOrderItemMemoResponse>
    {
        private readonly IOrderItemMemoRepository _orderItemMemoRepository;
        private readonly OrderItemMemoBusinessRules _orderItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderItemMemoQueryHandler(IOrderItemMemoRepository orderItemMemoRepository, IMapper mapper, OrderItemMemoBusinessRules orderItemMemoBusinessRules)
        {
            _orderItemMemoRepository = orderItemMemoRepository;
            _mapper = mapper;
            _orderItemMemoBusinessRules = orderItemMemoBusinessRules;
        }

        public async Task<GetByIdOrderItemMemoResponse> Handle(GetByIdOrderItemMemoQuery request, CancellationToken cancellationToken)
        {
            _orderItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderItemMemoResponse>(await _orderItemMemoRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<OrderItemMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrderItem)
                    {
                        query = query.Include(y => y.OrderItem);

                        if (detailLevel.OrderItemDetailLevel.IncludeOrder)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order);

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeCustomer)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Customer);
                            }

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeDepositor)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Depositor);
                            }

                            if (detailLevel.OrderItemDetailLevel.OrderDetailLevel.IncludeReceiver)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(m => m.Order).ThenInclude(n => n.Receiver);
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderItemMemo, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderItemMemoResponse>(await _orderItemMemoRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

