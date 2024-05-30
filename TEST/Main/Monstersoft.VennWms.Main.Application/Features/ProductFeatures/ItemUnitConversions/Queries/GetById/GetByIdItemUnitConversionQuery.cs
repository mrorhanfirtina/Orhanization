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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;

public class GetByIdItemUnitConversionQuery : IRequest<GetByIdItemUnitConversionResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ItemUnitConversionsDetailLevel DetailLevel { get; set; }



    public class GetByIdItemUnitConversionQueryHandler : IRequestHandler<GetByIdItemUnitConversionQuery, GetByIdItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _itemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemUnitConversionQueryHandler(IItemUnitConversionRepository itemUnitConversionRepository, IMapper mapper, ItemUnitConversionBusinessRules itemUnitConversionBusinessRules)
        {
            _itemUnitConversionRepository = itemUnitConversionRepository;
            _mapper = mapper;
            _itemUnitConversionBusinessRules = itemUnitConversionBusinessRules;
        }

        public async Task<GetByIdItemUnitConversionResponse> Handle(GetByIdItemUnitConversionQuery request, CancellationToken cancellationToken)
        {
            _itemUnitConversionBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdItemUnitConversionResponse>(await _itemUnitConversionRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdItemUnitConversionResponse>(await _itemUnitConversionRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

