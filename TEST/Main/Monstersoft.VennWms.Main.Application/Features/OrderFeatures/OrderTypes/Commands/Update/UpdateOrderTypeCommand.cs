using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants.OrderTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Update;

public class UpdateOrderTypeCommand : IRequest<UpdatedOrderTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderTypes";

    public UpdateOrderTypeDto OrderType { get; set; }
    public OrderTypesDetailLevel DetailLevel { get; set; }

    public class UpdateOrderTypeCommandHandler : IRequestHandler<UpdateOrderTypeCommand, UpdatedOrderTypeResponse>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderTypeCommandHandler(IOrderTypeRepository orderTypeRepository, OrderTypeBusinessRules orderTypeBusinessRules, IMapper mapper)
        {
            _orderTypeRepository = orderTypeRepository;
            _orderTypeBusinessRules = orderTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderTypeResponse> Handle(UpdateOrderTypeCommand request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderType.Id)
            .CheckCodeExistenceWhenUpdate(request.OrderType.Code, request.OrderType.Id);

            OrderType? currentOrderType = await _orderTypeRepository.GetAsync(predicate: x => x.Id == request.OrderType.Id);

            OrderType? orderType = _mapper.Map(request.OrderType, currentOrderType);
            orderType.UpdatedDate = DateTime.Now;

            await _orderTypeRepository.UpdateAsync(orderType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderTypeRepository.GetAsync(predicate: x => x.Id == orderType.Id,
                include: x =>
                {
                    IQueryable<OrderType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Orders);

                        if (detailLevel.OrderDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Depositor);
                        }

                        if (detailLevel.OrderDetailLevel.IncludeCustomer)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Customer);
                        }

                        if (detailLevel.OrderDetailLevel.IncludeReceiver)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Receiver);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderTypeResponse>(response);
            }
            else
            {
                var response = await _orderTypeRepository.GetAsync(predicate: x => x.Id == orderType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderTypeResponse>(response);
            }
        }
    }

}
