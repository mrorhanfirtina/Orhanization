using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;

public class UpdateItemUnitConversionCommand : IRequest<UpdatedItemUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ItemUnitConversionOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnitConversions";

    public UpdateItemUnitConversionDto ItemUnitConversion { get; set; }
    public ItemUnitConversionDetailLevel DetailLevel { get; set; }



    public class UpdateItemUnitConversionCommandHandler : IRequestHandler<UpdateItemUnitConversionCommand, UpdatedItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _itemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public UpdateItemUnitConversionCommandHandler(IItemUnitConversionRepository itemUnitConversionRepository, ItemUnitConversionBusinessRules itemUnitConversionBusinessRules, IMapper mapper)
        {
            _itemUnitConversionRepository = itemUnitConversionRepository;
            _itemUnitConversionBusinessRules = itemUnitConversionBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedItemUnitConversionResponse> Handle(UpdateItemUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _itemUnitConversionBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ItemUnitConversion.Id)
            .CheckConvertedItemUnitIdExistence(request.ItemUnitConversion.ConvertedItemUnitId)
            .CheckReferenceItemUnitIdExistence(request.ItemUnitConversion.ReferenceItemUnitId);

            ItemUnitConversion? currentItemUnitConversion = await _itemUnitConversionRepository.GetAsync(predicate: x => x.Id == request.ItemUnitConversion.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ItemUnitConversion? itemUnitConversion = _mapper.Map(request.ItemUnitConversion, currentItemUnitConversion);
            itemUnitConversion.UpdatedDate = DateTime.Now;

            await _itemUnitConversionRepository.UpdateAsync(itemUnitConversion);

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

                return _mapper.Map<UpdatedItemUnitConversionResponse>(response);
            }
            else
            {
                var response = await _itemUnitConversionRepository.GetAsync(predicate: x => x.Id == itemUnitConversion.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedItemUnitConversionResponse>(response);
            }
        }
    }
}

