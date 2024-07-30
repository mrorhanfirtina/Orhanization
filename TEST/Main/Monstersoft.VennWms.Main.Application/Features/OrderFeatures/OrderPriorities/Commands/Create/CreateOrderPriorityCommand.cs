using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants.OrderPriorityOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;

public class CreateOrderPriorityCommand : IRequest<CreatedOrderPriorityResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderPriorities"];

    public CreateOrderPriorityDto OrderPriority { get; set; }
    public OrderPrioritiesDetailLevel DetailLevel { get; set; }


    public class CreateOrderPriorityCommandHandler : IRequestHandler<CreateOrderPriorityCommand, CreatedOrderPriorityResponse>
    {
        private readonly IOrderPriorityRepository _orderPriorityRepository;
        private readonly OrderPriorityBusinessRules _orderPriorityBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderPriorityCommandHandler(IOrderPriorityRepository orderPriorityRepository, IMapper mapper, OrderPriorityBusinessRules orderPriorityBusinessRules)
        {
            _orderPriorityRepository = orderPriorityRepository;
            _mapper = mapper;
            _orderPriorityBusinessRules = orderPriorityBusinessRules;
        }

        public async Task<CreatedOrderPriorityResponse> Handle(CreateOrderPriorityCommand request, CancellationToken cancellationToken)
        {
            _orderPriorityBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            OrderPriority orderPriority = _mapper.Map<OrderPriority>(request.OrderPriority);
            orderPriority.Id = Guid.NewGuid();
            orderPriority.CreatedDate = DateTime.Now;

            await _orderPriorityRepository.AddAsync(orderPriority);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderPriorityRepository.GetAsync(predicate: x => x.Id == orderPriority.Id,
                include: x =>
                {
                    IQueryable<OrderPriority> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludePriorityList)
                    {
                        query = query.Include(y => y.Priority);
                    }


                    var includableQuery = query as IIncludableQueryable<OrderPriority, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderPriorityResponse>(response);
            }
            else
            {
                var response = await _orderPriorityRepository.GetAsync(predicate: x => x.Id == orderPriority.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderPriorityResponse>(response);
            }
        }
    }
}


