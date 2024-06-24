using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetListByDynamic;

public class GetListByDynamicItemUnitConversionQuery : IRequest<GetListResponse<GetListByDynamicItemUnitConversionListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ItemUnitConversionsDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicItemUnitConversionQueryHandler : IRequestHandler<GetListByDynamicItemUnitConversionQuery, GetListResponse<GetListByDynamicItemUnitConversionListItemDto>>
    {
        private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _itemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicItemUnitConversionQueryHandler(IItemUnitConversionRepository itemUnitConversionRepository, IMapper mapper, ItemUnitConversionBusinessRules itemUnitConversionBusinessRules)
        {
            _itemUnitConversionRepository = itemUnitConversionRepository;
            _itemUnitConversionBusinessRules = itemUnitConversionBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicItemUnitConversionListItemDto>> Handle(GetListByDynamicItemUnitConversionQuery request, CancellationToken cancellationToken)
        {
            _itemUnitConversionBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ItemUnitConversion> itemUnitConversionList = await _itemUnitConversionRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ItemUnitConversion> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReferenceItemUnit)
                    {
                        query = query.Include(y => y.ReferenceItemUnit);

                        if (detailLevel.ReferenceItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ReferenceItemUnit).ThenInclude(m => m.Unit);
                        }

                        if (detailLevel.ReferenceItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReferenceItemUnit).ThenInclude(m => m.Product);
                        }
                    }

                    if (detailLevel.IncludeConvertedItemUnit)
                    {
                        query = query.Include(y => y.ConvertedItemUnit);

                        if (detailLevel.ConvertedItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ConvertedItemUnit).ThenInclude(m => m.Unit);
                        }

                        if (detailLevel.ConvertedItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ConvertedItemUnit).ThenInclude(m => m.Product);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<ItemUnitConversion, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemUnitConversionListItemDto>>(itemUnitConversionList);
            }
            else
            {
                Paginate<ItemUnitConversion> itemUnitConversionList = await _itemUnitConversionRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemUnitConversionListItemDto>>(itemUnitConversionList);
            }
        }
    }
}

