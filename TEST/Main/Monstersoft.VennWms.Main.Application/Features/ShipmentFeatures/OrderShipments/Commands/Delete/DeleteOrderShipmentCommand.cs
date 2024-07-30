using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Delete;

public class DeleteOrderShipmentCommand : IRequest<DeletedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderShipmentOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderShipments"];

    public Guid Id { get; set; }


    public class DeleteOrderShipmentCommandHandler : IRequestHandler<DeleteOrderShipmentCommand, DeletedOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;

        public DeleteOrderShipmentCommandHandler(IOrderShipmentRepository orderShipmentRepository, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<DeletedOrderShipmentResponse> Handle(DeleteOrderShipmentCommand request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderShipment orderShipment = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.OrderShipItems),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _orderShipmentRepository.DeleteAsync(orderShipment);

            return new DeletedOrderShipmentResponse
            {
                Id = orderShipment.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderShipmentMessages.RequestExecutedSuccessfully
            };
        }
    }
}
