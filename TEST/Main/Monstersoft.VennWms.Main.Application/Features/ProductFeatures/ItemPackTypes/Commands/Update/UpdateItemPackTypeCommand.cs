using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public ItemPackTypesDetailLevel DetailLevel { get; set; }


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

            await _itemPackTypeRepository.UpdateAsync(itemPackType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == itemPackType.Id,
                include: x =>
                {
                    IQueryable<ItemPackType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLenghtUnit)
                    {
                        query = query.Include(y => y.LenghtUnit);
                    }

                    if (detailLevel.IncludeVolumeUnit)
                    {
                        query = query.Include(y => y.VolumeUnit);
                    }

                    if (detailLevel.IncludeWeightUnit)
                    {
                        query = query.Include(y => y.WeightUnit);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);
                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ItemPackType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedItemPackTypeResponse>(response);
            }
            else
            {
                var response = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == itemPackType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedItemPackTypeResponse>(response);
            }
        }
    }
}
