using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Create;

public class CreateItemUnitCommand : IRequest<CreatedItemUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnits";

    public CreateItemUnitDto ItemUnit { get; set; }
    public ItemUnitsDetailLevel DetailLevel { get; set; }



    public class CreateItemUnitCommandHandler : IRequestHandler<CreateItemUnitCommand, CreatedItemUnitResponse>
    {
        private readonly IItemUnitRepository _itemUnitRepository;
        private readonly IMapper _mapper;
        private readonly ItemUnitBusinessRules _itemUnitBusinessRules;

        public CreateItemUnitCommandHandler(IItemUnitRepository itemUnitRepository, IMapper mapper, ItemUnitBusinessRules itemUnitBusinessRules)
        {
            _itemUnitRepository = itemUnitRepository;
            _mapper = mapper;
            _itemUnitBusinessRules = itemUnitBusinessRules;
        }

        public async Task<CreatedItemUnitResponse> Handle(CreateItemUnitCommand request, CancellationToken cancellationToken)
        {
            _itemUnitBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            ItemUnit? itemUnit = _mapper.Map<ItemUnit>(request.ItemUnit);

            itemUnit.CreatedDate = DateTime.Now;
            itemUnit.Id = Guid.NewGuid();

            itemUnit.ItemPackTypes.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            itemUnit.ItemUnitConversions.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            await _itemUnitRepository.AddAsync(itemUnit);

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

                return _mapper.Map<CreatedItemUnitResponse>(response);
            }
            else
            {
                var response = await _itemUnitRepository.GetAsync(predicate: x => x.Id == itemUnit.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedItemUnitResponse>(response);
            }
        }
    }
}
