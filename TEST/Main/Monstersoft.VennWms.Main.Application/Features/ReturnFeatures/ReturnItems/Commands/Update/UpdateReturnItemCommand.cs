using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;

public class UpdateReturnItemCommand : IRequest<UpdatedReturnItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItems"];

    public UpdateReturnItemDto ReturnItem { get; set; }
    public ReturnItemsDetailLevel? DetailLevel { get; set; }


    public class UpdateReturnItemCommandHandler : IRequestHandler<UpdateReturnItemCommand, UpdatedReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly IMapper _mapper;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;

        public UpdateReturnItemCommandHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _mapper = mapper;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<UpdatedReturnItemResponse> Handle(UpdateReturnItemCommand request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnItem.Id);

            ReturnItem? currentReturnItem = await _returnItemRepository.GetAsync(predicate: x => x.Id == request.ReturnItem.Id,
            include: x => x.Include(y => y.ReturnItemMemos)
            .Include(y => y.ReturnItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnItem? returnItem = _mapper.Map(request.ReturnItem, currentReturnItem);
            returnItem.UpdatedDate = DateTime.Now;

            returnItem.ReturnItemMemos?.ToList().ForEach(x => { x.CreatedDate = returnItem.CreatedDate; x.UpdatedDate = DateTime.Now; });
            returnItem.ReturnItmStockAttrValues?.ToList().ForEach(x => { x.CreatedDate = returnItem.CreatedDate; x.UpdatedDate = DateTime.Now; });

            await _returnItemRepository.UpdateAsync(currentReturnItem);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _returnItemRepository.GetAsync(predicate: x => x.Id == returnItem.Id,
                include: x =>
                {
                    IQueryable<ReturnItem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeReturnItemMemo)
                    {
                        query = query.Include(y => y.ReturnItemMemos);
                    }

                    if (detailLevel.IncludeReturnItmStockAttrValue)
                    {
                        query = query.Include(y => y.ReturnItmStockAttrValues);

                        var returnItmStockAttrValueDetailLevel = detailLevel.ReturnItmStockAttrValueDetailLevel;

                        if (returnItmStockAttrValueDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                            var stockAttributeDetailLevel = returnItmStockAttrValueDetailLevel.StockAttributeDetailLevel;

                            if (stockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(y => y.Unit);
                        }
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnItem, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnItemResponse>(response);
            }
            else
            {
                var response = await _returnItemRepository.GetAsync(predicate: x => x.Id == returnItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnItemResponse>(response);
            }
        }
    }
}
