using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;

public class CreateOrderAttributeCommand : IRequest<CreatedOrderAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderAttributes";

    public CreateOrderAttributeDto OrderAttribute { get; set; }


    public class CreateOrderAttributeCommandHandler : IRequestHandler<CreateOrderAttributeCommand, CreatedOrderAttributeResponse>
    {
        private readonly IOrderAttributeRepository _orderAttributeRepository;
        private readonly OrderAttributeBusinessRules _orderAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderAttributeCommandHandler(IOrderAttributeRepository orderAttributeRepository, IMapper mapper, OrderAttributeBusinessRules orderAttributeBusinessRules)
        {
            _orderAttributeRepository = orderAttributeRepository;
            _mapper = mapper;
            _orderAttributeBusinessRules = orderAttributeBusinessRules;
        }

        public async Task<CreatedOrderAttributeResponse> Handle(CreateOrderAttributeCommand request, CancellationToken cancellationToken)
        {
            _orderAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.OrderAttribute.Code)
                .CheckAttributeInputTypeIdExistence(request.OrderAttribute.AttributeInputTypeId);

            OrderAttribute orderAttribute = _mapper.Map<OrderAttribute>(request.OrderAttribute);
            orderAttribute.Id = Guid.NewGuid();
            orderAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            orderAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedOrderAttributeResponse>(await _orderAttributeRepository.AddAsync(orderAttribute));
        }
    }

}

