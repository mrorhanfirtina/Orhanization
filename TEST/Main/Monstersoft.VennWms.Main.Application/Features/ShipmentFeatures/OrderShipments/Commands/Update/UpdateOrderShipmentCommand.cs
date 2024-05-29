using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Update;

public class UpdateOrderShipmentCommand : IRequest<UpdatedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipmentOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipments";

    public UpdateOrderShipmentDto OrderShipment { get; set; }


    public class UpdateOrderShipmentCommandHandler : IRequestHandler<UpdateOrderShipmentCommand, UpdatedOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;

        public UpdateOrderShipmentCommandHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<UpdatedOrderShipmentResponse> Handle(UpdateOrderShipmentCommand request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipment.Id);

            OrderShipment? currentOrderShipment = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == request.OrderShipment.Id,
            include: x => x.Include(y => y.OrderShipItems),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderShipment? orderShipment = _mapper.Map(request.OrderShipment, currentOrderShipment);
            orderShipment.UpdatedDate = DateTime.Now;

            orderShipment.OrderShipItems.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = orderShipment.CreatedDate;
            });

            return _mapper.Map<UpdatedOrderShipmentResponse>(await _orderShipmentRepository.UpdateAsync(currentOrderShipment));
        }
    }
}
