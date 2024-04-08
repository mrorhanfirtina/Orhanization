using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Update;

public class UpdateItemPackTypeCommand : IRequest<UpdatedItemPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ItemPackTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemPackTypes";

    public UpdateItemPackTypeDto ItemPackType { get; set; }


    public class UpdateItemPackTypeCommandHandler : IRequestHandler<UpdateItemPackTypeCommand, UpdatedItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateItemPackTypeCommandHandler(IItemPackTypeRepository itemPackTypeRepository, ItemPackTypeBusinessRules itemPackTypeBusinessRules, IMapper mapper)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedItemPackTypeResponse> Handle(UpdateItemPackTypeCommand request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ItemPackType.Id)
            .CheckItemUnitIdExistence(request.ItemPackType.ItemUnitId)
            .CheckWeightUnitIdExistence(request.ItemPackType.WeightUnitId)
            .CheckLenghtUnitIdExistence(request.ItemPackType.LenghtUnitId)
            .CheckVolumeUnitIdExistence(request.ItemPackType.VolumeUnitId);

            ItemPackType? currentItemPackType = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == request.ItemPackType.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ItemPackType? itemPackType = _mapper.Map(request.ItemPackType, currentItemPackType);
            itemPackType.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedItemPackTypeResponse>(await _itemPackTypeRepository.UpdateAsync(itemPackType));
        }
    }
}
