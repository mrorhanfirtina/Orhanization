using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;

public class UpdateItemUnitCommand : IRequest<UpdatedItemUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ItemUnitOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetItemUnits"];

    public UpdateItemUnitDto ItemUnit { get; set; }
    public ItemUnitsDetailLevel DetailLevel { get; set; }


    public class UpdateItemUnitCommandHandler : IRequestHandler<UpdateItemUnitCommand, UpdatedItemUnitResponse>
    {
        private readonly IItemUnitRepository _itemUnitRepository;
        private readonly IMapper _mapper;
        private readonly ItemUnitBusinessRules _itemUnitBusinessRules;

        public UpdateItemUnitCommandHandler(IItemUnitRepository itemUnitRepository, IMapper mapper, ItemUnitBusinessRules itemUnitBusinessRules)
        {
            _itemUnitRepository = itemUnitRepository;
            _mapper = mapper;
            _itemUnitBusinessRules = itemUnitBusinessRules;
        }

        public async Task<UpdatedItemUnitResponse> Handle(UpdateItemUnitCommand request, CancellationToken cancellationToken)
        {
            _itemUnitBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ItemUnit.Id);

            ItemUnit currentItemUnit = await _itemUnitRepository.GetAsync(predicate: x => x.Id == request.ItemUnit.Id,
            include: x => x.Include(y => y.ItemPackTypes),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            ItemUnit itemUnit = _mapper.Map(request.ItemUnit, currentItemUnit);

            itemUnit.UpdatedDate = DateTime.Now;

            itemUnit.ItemPackTypes.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
            });

            itemUnit.ItemUnitConversions.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
            });

            await _itemUnitRepository.UpdateAsync(itemUnit);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _itemUnitRepository.GetAsync(predicate: x => x.Id == itemUnit.Id,
                include: x =>
                {
                    IQueryable<ItemUnit> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeUnit)
                    {
                        query = query.Include(y => y.Unit);
                    }

                    if (detailLevel.IncludeItemPackType)
                    {
                        query = query.Include(y => y.ItemPackTypes);

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeLenghtUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.LenghtUnit);
                        }

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeVolumeUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.VolumeUnit);
                        }

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeWeightUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.WeightUnit);
                        }
                    }

                    if (detailLevel.IncludeItemUnitConversion)
                    {
                        query = query.Include(y => y.ItemUnitConversions);

                        if (detailLevel.ItemUnitConversionDetailLevel.IncludeConvertedItemUnit)
                        {
                            query = query.Include(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit);

                            if (detailLevel.ItemUnitConversionDetailLevel.ConvertedItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ItemUnit, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedItemUnitResponse>(response);
            }
            else
            {
                var response = await _itemUnitRepository.GetAsync(predicate: x => x.Id == itemUnit.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedItemUnitResponse>(response);
            }
        }
    }
}
