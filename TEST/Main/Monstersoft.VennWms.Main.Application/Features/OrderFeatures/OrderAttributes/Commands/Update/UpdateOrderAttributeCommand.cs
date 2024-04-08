using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
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
    public string? CacheGroupKey => "GetOrderAttributes";

    public UpdateOrderAttributeDto OrderAttribute { get; set; }

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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedOrderAttributeResponse>(await _orderAttributeRepository.UpdateAsync(orderAttribute));
        }
    }
}

