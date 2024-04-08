using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants.OrderAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;

public class UpdateOrderAttributeValueCommand : IRequest<UpdatedOrderAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderAttributeValues";

    public UpdateOrderAttributeValueDto OrderAttributeValue { get; set; }


    public class UpdateOrderAttributeValueCommandHandler : IRequestHandler<UpdateOrderAttributeValueCommand, UpdatedOrderAttributeValueResponse>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderAttributeValueCommandHandler(IOrderAttributeValueRepository orderAttributeValueRepository, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules, IMapper mapper)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderAttributeValueResponse> Handle(UpdateOrderAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderAttributeValue.Id)
            .CheckOrderIdExistence(request.OrderAttributeValue.OrderId)
            .CheckOrderAttributeIdExistence(request.OrderAttributeValue.OrderAttributeId);

            OrderAttributeValue? currentOrderAttributeValue = await _orderAttributeValueRepository.GetAsync(predicate: x => x.Id == request.OrderAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderAttributeValue? orderAttributeValue = _mapper.Map(request.OrderAttributeValue, currentOrderAttributeValue);
            orderAttributeValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedOrderAttributeValueResponse>(await _orderAttributeValueRepository.UpdateAsync(orderAttributeValue));
        }
    }
}
