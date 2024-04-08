using MediatR;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Delete;

public class DeleteOrderAttributeValueCommand : IRequest<DeletedOrderAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderAttributeValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderAttributeValues";

    public Guid Id { get; set; }


    public class DeleteOrderAttributeValueCommandHandler : IRequestHandler<DeleteOrderAttributeValueCommand, DeletedOrderAttributeValueResponse>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;

        public DeleteOrderAttributeValueCommandHandler(IOrderAttributeValueRepository orderAttributeValueRepository, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
        }

        public async Task<DeletedOrderAttributeValueResponse> Handle(DeleteOrderAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderAttributeValue orderAttributeValue = await _orderAttributeValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderAttributeValueRepository.DeleteAsync(orderAttributeValue);

            return new DeletedOrderAttributeValueResponse
            {
                Id = orderAttributeValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderAttributeValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}
