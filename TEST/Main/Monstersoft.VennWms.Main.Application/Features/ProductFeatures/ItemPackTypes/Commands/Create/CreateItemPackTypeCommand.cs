using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;

public class CreateItemPackTypeCommand : IRequest<CreatedItemPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemPackTypes";

    public CreateItemPackTypeDto ItemPackType { get; set; }


    public class CreateItemPackTypeCommandHandler : IRequestHandler<CreateItemPackTypeCommand, CreatedItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public CreateItemPackTypeCommandHandler(IItemPackTypeRepository itemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules itemPackTypeBusinessRules)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _mapper = mapper;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
        }

        public async Task<CreatedItemPackTypeResponse> Handle(CreateItemPackTypeCommand request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckItemUnitIdExistence(request.ItemPackType.ItemUnitId)
                .CheckWeightUnitIdExistence(request.ItemPackType.WeightUnitId)
                .CheckLenghtUnitIdExistence(request.ItemPackType.LenghtUnitId)
                .CheckVolumeUnitIdExistence(request.ItemPackType.VolumeUnitId);
            //Eğer tüm idlerin birebir aynı olarak eklendiği bir durum varsa hata verecek.

            ItemPackType itemPackType = _mapper.Map<ItemPackType>(request.ItemPackType);
            itemPackType.Id = Guid.NewGuid();
            itemPackType.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedItemPackTypeResponse>(await _itemPackTypeRepository.AddAsync(itemPackType));
        }
    }
}
