using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Create;
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

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Update;

public class UpdateOrderPriorityCommand : IRequest<UpdatedOrderPriorityResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, OrderPriorityOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderPriorities"];

    public UpdateOrderPriorityDto OrderPriority { get; set; }
    public OrderPrioritiesDetailLevel DetailLevel { get; set; }

    public class UpdateOrderPriorityCommandHandler : IRequestHandler<UpdateOrderPriorityCommand, UpdatedOrderPriorityResponse>
    {
        private readonly IOrderPriorityRepository _orderPriorityRepository;
        private readonly OrderPriorityBusinessRules _orderPriorityBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderPriorityCommandHandler(IOrderPriorityRepository orderPriorityRepository, OrderPriorityBusinessRules orderPriorityBusinessRules, IMapper mapper)
        {
            _orderPriorityRepository = orderPriorityRepository;
            _orderPriorityBusinessRules = orderPriorityBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderPriorityResponse> Handle(UpdateOrderPriorityCommand request, CancellationToken cancellationToken)
        {
            _orderPriorityBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            OrderPriority? currentOrderPriority = await _orderPriorityRepository.GetAsync(predicate: x => x.Id == request.OrderPriority.Id);

            OrderPriority? orderPriority = _mapper.Map(request.OrderPriority, currentOrderPriority);
            orderPriority.UpdatedDate = DateTime.Now;

            await _orderPriorityRepository.UpdateAsync(orderPriority);

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

                return _mapper.Map<UpdatedOrderPriorityResponse>(response);
            }
            else
            {
                var response = await _orderPriorityRepository.GetAsync(predicate: x => x.Id == orderPriority.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderPriorityResponse>(response);
            }
        }
    }
}


