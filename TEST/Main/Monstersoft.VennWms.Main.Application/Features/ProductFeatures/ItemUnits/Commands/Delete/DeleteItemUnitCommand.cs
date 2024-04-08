using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Delete;

public class DeleteItemUnitCommand : IRequest<DeletedItemUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ItemUnitOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnits";

    public Guid Id { get; set; }


    public class DeleteItemUnitCommandHandler : IRequestHandler<DeleteItemUnitCommand, DeletedItemUnitResponse>
    {
        private readonly IItemUnitRepository _itemUnitRepository;
        private readonly ItemUnitBusinessRules _itemUnitBusinessRules;

        public DeleteItemUnitCommandHandler(IItemUnitRepository itemUnitRepository, ItemUnitBusinessRules itemUnitBusinessRules)
        {
            _itemUnitRepository = itemUnitRepository;
            _itemUnitBusinessRules = itemUnitBusinessRules;
        }

        public async Task<DeletedItemUnitResponse> Handle(DeleteItemUnitCommand request, CancellationToken cancellationToken)
        {
            _itemUnitBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ItemUnit itemUnit = await _itemUnitRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _itemUnitRepository.DeleteAsync(itemUnit);

            return new DeletedItemUnitResponse
            {
                Id = itemUnit.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ItemUnitMessages.RequestExecutedSuccessfully
            };
        }
    }
}
