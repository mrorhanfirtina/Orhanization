using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants.OrderShipItemTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Delete;

public class DeleteOrderShipItemTaskCommand : IRequest<DeletedOrderShipItemTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderShipItemTaskOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItemTasks";

    public Guid Id { get; set; }


    public class DeleteOrderShipItemTaskCommandHandler : IRequestHandler<DeleteOrderShipItemTaskCommand, DeletedOrderShipItemTaskResponse>
    {
        private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
        private readonly OrderShipItemTaskBusinessRules _orderShipItemTaskBusinessRules;

        public DeleteOrderShipItemTaskCommandHandler(IOrderShipItemTaskRepository orderShipItemTaskRepository, OrderShipItemTaskBusinessRules orderShipItemTaskBusinessRules)
        {
            _orderShipItemTaskRepository = orderShipItemTaskRepository;
            _orderShipItemTaskBusinessRules = orderShipItemTaskBusinessRules;
        }

        public async Task<DeletedOrderShipItemTaskResponse> Handle(DeleteOrderShipItemTaskCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemTaskBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderShipItemTask orderShipItemTask = await _orderShipItemTaskRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.OrderShipItemStocks),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _orderShipItemTaskRepository.DeleteAsync(orderShipItemTask);

            return new DeletedOrderShipItemTaskResponse
            {
                Id = orderShipItemTask.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderShipItemTaskMessages.RequestExecutedSuccessfully
            };
        }
    }
}
