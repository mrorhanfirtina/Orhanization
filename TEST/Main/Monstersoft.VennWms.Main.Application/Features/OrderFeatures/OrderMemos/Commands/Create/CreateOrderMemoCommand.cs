using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants.OrderMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;

public class CreateOrderMemoCommand : IRequest<CreatedOrderMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderMemos"];

    public CreateOrderMemoDto OrderMemo { get; set; }
    public OrderMemosDetailLevel DetailLevel { get; set; }


    public class CreateOrderMemoCommandHandler : IRequestHandler<CreateOrderMemoCommand, CreatedOrderMemoResponse>
    {
        private readonly IOrderMemoRepository _orderMemoRepository;
        private readonly OrderMemoBusinessRules _orderMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderMemoCommandHandler(IOrderMemoRepository orderMemoRepository, IMapper mapper, OrderMemoBusinessRules orderMemoBusinessRules)
        {
            _orderMemoRepository = orderMemoRepository;
            _mapper = mapper;
            _orderMemoBusinessRules = orderMemoBusinessRules;
        }

        public async Task<CreatedOrderMemoResponse> Handle(CreateOrderMemoCommand request, CancellationToken cancellationToken)
        {
            _orderMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckOrderIdExistence(request.OrderMemo.OrderId);

            OrderMemo orderMemo = _mapper.Map<OrderMemo>(request.OrderMemo);
            orderMemo.Id = Guid.NewGuid();
            orderMemo.CreatedDate = DateTime.Now;

            await _orderMemoRepository.AddAsync(orderMemo);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderMemoRepository.GetAsync(predicate: x => x.Id == orderMemo.Id,
                include: x =>
                {
                    IQueryable<OrderMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }


                    var includableQuery = query as IIncludableQueryable<OrderMemo, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderMemoResponse>(response);
            }
            else
            {
                var response = await _orderMemoRepository.GetAsync(predicate: x => x.Id == orderMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderMemoResponse>(response);
            }
        }
    }

}

