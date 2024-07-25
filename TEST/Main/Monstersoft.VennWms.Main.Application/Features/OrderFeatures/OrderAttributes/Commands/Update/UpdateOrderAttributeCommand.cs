using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants.OrderAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Update;

public class UpdateOrderAttributeCommand : IRequest<UpdatedOrderAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderAttributes"];

    public UpdateOrderAttributeDto OrderAttribute { get; set; }
    public OrderAttributesDetailLevel DetailLevel { get; set; }


    public class UpdateOrderAttributeCommandHandler : IRequestHandler<UpdateOrderAttributeCommand, UpdatedOrderAttributeResponse>
    {
        private readonly IOrderAttributeRepository _orderAttributeRepository;
        private readonly OrderAttributeBusinessRules _orderAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderAttributeCommandHandler(IOrderAttributeRepository orderAttributeRepository, OrderAttributeBusinessRules orderAttributeBusinessRules, IMapper mapper)
        {
            _orderAttributeRepository = orderAttributeRepository;
            _orderAttributeBusinessRules = orderAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderAttributeResponse> Handle(UpdateOrderAttributeCommand request, CancellationToken cancellationToken)
        {
            _orderAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderAttribute.Id)
            .CheckCodeExistenceWhenUpdate(request.OrderAttribute.Code, request.OrderAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.OrderAttribute.AttributeInputTypeId);


            OrderAttribute? currentOrderAttribute = await _orderAttributeRepository.GetAsync(predicate: x => x.Id == request.OrderAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderAttribute? orderAttribute = _mapper.Map(request.OrderAttribute, currentOrderAttribute);
            orderAttribute.UpdatedDate = DateTime.Now;

            await _orderAttributeRepository.UpdateAsync(orderAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderAttributeRepository.GetAsync(predicate: x => x.Id == orderAttribute.Id,
                include: x =>
                {
                    IQueryable<OrderAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }


                    var includableQuery = query as IIncludableQueryable<OrderAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderAttributeResponse>(response);
            }
            else
            {
                var response = await _orderAttributeRepository.GetAsync(predicate: x => x.Id == orderAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderAttributeResponse>(response);
            }
        }
    }
}

