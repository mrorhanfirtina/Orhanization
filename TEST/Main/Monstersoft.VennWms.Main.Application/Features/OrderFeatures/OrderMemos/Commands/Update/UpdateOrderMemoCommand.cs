using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Update;

public class UpdateOrderMemoCommand : IRequest<UpdatedOrderMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderMemos"];

    public UpdateOrderMemoDto OrderMemo { get; set; }
    public OrderMemosDetailLevel DetailLevel { get; set; }

    public class UpdateOrderMemoCommandHandler : IRequestHandler<UpdateOrderMemoCommand, UpdatedOrderMemoResponse>
    {
        private readonly IOrderMemoRepository _orderMemoRepository;
        private readonly OrderMemoBusinessRules _orderMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderMemoCommandHandler(IOrderMemoRepository orderMemoRepository, OrderMemoBusinessRules orderMemoBusinessRules, IMapper mapper)
        {
            _orderMemoRepository = orderMemoRepository;
            _orderMemoBusinessRules = orderMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderMemoResponse> Handle(UpdateOrderMemoCommand request, CancellationToken cancellationToken)
        {
            _orderMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderMemo.Id)
            .CheckOrderIdExistence(request.OrderMemo.OrderId);

            OrderMemo? currentOrderMemo = await _orderMemoRepository.GetAsync(predicate: x => x.Id == request.OrderMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderMemo? orderMemo = _mapper.Map(request.OrderMemo, currentOrderMemo);
            orderMemo.UpdatedDate = DateTime.Now;

            await _orderMemoRepository.UpdateAsync(orderMemo);

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

                return _mapper.Map<UpdatedOrderMemoResponse>(response);
            }
            else
            {
                var response = await _orderMemoRepository.GetAsync(predicate: x => x.Id == orderMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderMemoResponse>(response);
            }
        }
    }
}

