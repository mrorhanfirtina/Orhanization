using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetListByDynamic;

public class GetListByDynamicItemPackTypeQuery : IRequest<GetListResponse<GetListByDynamicItemPackTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ItemPackTypesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicItemPackTypeQueryHandler : IRequestHandler<GetListByDynamicItemPackTypeQuery, GetListResponse<GetListByDynamicItemPackTypeListItemDto>>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicItemPackTypeQueryHandler(IItemPackTypeRepository itemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules itemPackTypeBusinessRules)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicItemPackTypeListItemDto>> Handle(GetListByDynamicItemPackTypeQuery request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ItemPackType> itemPackTypeList = await _itemPackTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemPackTypeListItemDto>>(itemPackTypeList);
            }
            else
            {
                Paginate<ItemPackType> itemPackTypeList = await _itemPackTypeRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicItemPackTypeListItemDto>>(itemPackTypeList);
            }
        }
    }

}
