using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;

public class CreateItemUnitConversionCommand : IRequest<CreatedItemUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnitConversions";

    public CreateItemUnitConversionDto ItemUnitConversion { get; set; }
    public ItemUnitConversionDetailLevel DetailLevel { get; set; }



    public class CreateItemUnitConversionCommandHandler : IRequestHandler<CreateItemUnitConversionCommand, CreatedItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _itemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public CreateItemUnitConversionCommandHandler(IItemUnitConversionRepository itemUnitConversionRepository, IMapper mapper, ItemUnitConversionBusinessRules itemUnitConversionBusinessRules)
        {
            _itemUnitConversionRepository = itemUnitConversionRepository;
            _mapper = mapper;
            _itemUnitConversionBusinessRules = itemUnitConversionBusinessRules;
        }

        public async Task<CreatedItemUnitConversionResponse> Handle(CreateItemUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _itemUnitConversionBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReferenceItemUnitIdExistence(request.ItemUnitConversion.ReferenceItemUnitId)
                .CheckConvertedItemUnitIdExistence(request.ItemUnitConversion.ConvertedItemUnitId);
            // Eğer iki id de daha önceden eklenmişse hata verecek.

            ItemUnitConversion itemUnitConversion = _mapper.Map<ItemUnitConversion>(request.ItemUnitConversion);
            itemUnitConversion.Id = Guid.NewGuid();
            itemUnitConversion.CreatedDate = DateTime.Now;

            await _itemUnitConversionRepository.AddAsync(itemUnitConversion);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _itemUnitConversionRepository.GetAsync(predicate: x => x.Id == itemUnitConversion.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedItemUnitConversionResponse>(response);
            }
            else
            {
                var response = await _itemUnitConversionRepository.GetAsync(predicate: x => x.Id == itemUnitConversion.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedItemUnitConversionResponse>(response);
            }
        }
    }
}

