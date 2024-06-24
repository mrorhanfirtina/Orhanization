using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Delete;

public class DeleteItemPackTypeCommand : IRequest<DeletedItemPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ItemPackTypeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemPackTypes";

    public Guid Id { get; set; }


    public class DeleteItemPackTypeCommandHandler : IRequestHandler<DeleteItemPackTypeCommand, DeletedItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;

        public DeleteItemPackTypeCommandHandler(IItemPackTypeRepository itemPackTypeRepository, ItemPackTypeBusinessRules itemPackTypeBusinessRules)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
        }

        public async Task<DeletedItemPackTypeResponse> Handle(DeleteItemPackTypeCommand request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ItemPackType itemPackType = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _itemPackTypeRepository.DeleteAsync(itemPackType);

            return new DeletedItemPackTypeResponse
            {
                Id = itemPackType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ItemPackTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}
