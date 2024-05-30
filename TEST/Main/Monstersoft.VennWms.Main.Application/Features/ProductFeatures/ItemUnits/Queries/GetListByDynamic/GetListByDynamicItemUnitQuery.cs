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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetListByDynamic;

public class GetListByDynamicItemUnitQuery : IRequest<GetListResponse<GetListByDynamicItemUnitListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ItemUnitsDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicItemUnitQueryHandler : IRequestHandler<GetListByDynamicItemUnitQuery, GetListResponse<GetListByDynamicItemUnitListItemDto>>
    {
        private readonly IItemUnitRepository _itemUnitRepository;
        private readonly ItemUnitBusinessRules _itemUnitBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicItemUnitQueryHandler(IItemUnitRepository itemUnitRepository, IMapper mapper, ItemUnitBusinessRules itemUnitBusinessRules)
        {
            _itemUnitRepository = itemUnitRepository;
            _itemUnitBusinessRules = itemUnitBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicItemUnitListItemDto>> Handle(GetListByDynamicItemUnitQuery request, CancellationToken cancellationToken)
        {
            _itemUnitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ItemUnit> itemUnitList = await _itemUnitRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                },
                index: request.PageRequest.PageIndex, enableTracking: true,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemUnitListItemDto>>(itemUnitList);
            }
            else
            {
                Paginate<ItemUnit> itemUnitList = await _itemUnitRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: true,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemUnitListItemDto>>(itemUnitList);
            }
        }
    }

}
