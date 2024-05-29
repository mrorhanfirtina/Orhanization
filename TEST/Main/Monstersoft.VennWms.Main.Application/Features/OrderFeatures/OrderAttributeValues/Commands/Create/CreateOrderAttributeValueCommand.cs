using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants.OrderAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;

public class CreateOrderAttributeValueCommand : IRequest<CreatedOrderAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderAttributeValues";

    public CreateOrderAttributeValueDto OrderAttributeValue { get; set; }
    public OrderAttributeValueDetailLevel DetailLevel { get; set; }


    public class CreateOrderAttributeValueCommandHandler : IRequestHandler<CreateOrderAttributeValueCommand, CreatedOrderAttributeValueResponse>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderAttributeValueCommandHandler(IOrderAttributeValueRepository orderAttributeValueRepository, IMapper mapper, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _mapper = mapper;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
        }

        public async Task<CreatedOrderAttributeValueResponse> Handle(CreateOrderAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckOrderAttributeIdExistence(request.OrderAttributeValue.OrderAttributeId)
                .CheckOrderIdExistence(request.OrderAttributeValue.OrderId);

            OrderAttributeValue orderAttributeValue = _mapper.Map<OrderAttributeValue>(request.OrderAttributeValue);
            orderAttributeValue.Id = Guid.NewGuid();
            orderAttributeValue.CreatedDate = DateTime.Now;

            await _orderAttributeValueRepository.AddAsync(orderAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderAttributeValueRepository.GetAsync(predicate: x => x.Id == orderAttributeValue.Id,
                include: x =>
                {
                    IQueryable<OrderAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludeOrderAttribute)
                    {
                        query = query.Include(y => y.OrderAttribute);

                        if (detailLevel.OrderAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.OrderAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderAttributeValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderAttributeValueResponse>(response);
            }
            else
            {
                var response = await _orderAttributeValueRepository.GetAsync(predicate: x => x.Id == orderAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderAttributeValueResponse>(response);
            }
        }
    }

}
