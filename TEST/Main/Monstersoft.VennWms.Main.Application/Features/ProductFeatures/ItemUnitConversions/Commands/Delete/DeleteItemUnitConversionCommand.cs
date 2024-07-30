using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Delete;

public class DeleteItemUnitConversionCommand : IRequest<DeletedItemUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ItemUnitConversionOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetItemUnitConversions"];

    public Guid Id { get; set; }


    public class DeleteItemUnitConversionCommandHandler : IRequestHandler<DeleteItemUnitConversionCommand, DeletedItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _itemUnitConversionBusinessRules;

        public DeleteItemUnitConversionCommandHandler(IItemUnitConversionRepository itemUnitConversionRepository, ItemUnitConversionBusinessRules itemUnitConversionBusinessRules)
        {
            _itemUnitConversionRepository = itemUnitConversionRepository;
            _itemUnitConversionBusinessRules = itemUnitConversionBusinessRules;
        }

        public async Task<DeletedItemUnitConversionResponse> Handle(DeleteItemUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _itemUnitConversionBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ItemUnitConversion itemUnitConversion = await _itemUnitConversionRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _itemUnitConversionRepository.DeleteAsync(itemUnitConversion);

            return new DeletedItemUnitConversionResponse
            {
                Id = itemUnitConversion.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ItemUnitConversionMessages.RequestExecutedSuccessfully
            };
        }
    }
}

