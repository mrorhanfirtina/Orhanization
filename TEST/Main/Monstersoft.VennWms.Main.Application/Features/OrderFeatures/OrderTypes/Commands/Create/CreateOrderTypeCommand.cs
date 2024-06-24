using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;

public class CreateOrderTypeCommand : IRequest<CreatedOrderTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderTypes";

    public CreateOrderTypeDto OrderType { get; set; }
    public OrderTypesDetailLevel DetailLevel { get; set; }


    public class CreateOrderTypeCommandHandler : IRequestHandler<CreateOrderTypeCommand, CreatedOrderTypeResponse>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderTypeCommandHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _mapper = mapper;
            _orderTypeBusinessRules = orderTypeBusinessRules;
        }

        public async Task<CreatedOrderTypeResponse> Handle(CreateOrderTypeCommand request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.OrderType.Code);

            OrderType orderType = _mapper.Map<OrderType>(request.OrderType);
            orderType.Id = Guid.NewGuid();
            orderType.CreatedDate = DateTime.Now;
            orderType.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            await _orderTypeRepository.AddAsync(orderType);

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

                return _mapper.Map<CreatedOrderTypeResponse>(response);
            }
            else
            {
                var response = await _orderTypeRepository.GetAsync(predicate: x => x.Id == orderType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderTypeResponse>(response);
            }
        }
    }

}
