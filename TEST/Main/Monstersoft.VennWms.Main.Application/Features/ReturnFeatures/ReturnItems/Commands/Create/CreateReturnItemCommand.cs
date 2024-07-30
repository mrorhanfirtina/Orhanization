using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;

public class CreateReturnItemCommand : IRequest<CreatedReturnItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItems"];


    public CreateReturnItemDto ReturnItem { get; set; }
    public ReturnItemsDetailLevel? DetailLevel { get; set; }


    public class CreateReturnItemCommandHandler : IRequestHandler<CreateReturnItemCommand, CreatedReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly IMapper _mapper;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;

        public CreateReturnItemCommandHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _mapper = mapper;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<CreatedReturnItemResponse> Handle(CreateReturnItemCommand request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            ReturnItem? returnItem = _mapper.Map<ReturnItem>(request.ReturnItem);

            returnItem.CreatedDate = DateTime.Now;
            returnItem.Id = Guid.NewGuid();

            returnItem.ReturnItemMemos?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            returnItem.ReturnItmStockAttrValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            await _returnItemRepository.AddAsync(returnItem);

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

                return _mapper.Map<CreatedReturnItemResponse>(response);
            }
            else
            {
                var response = await _returnItemRepository.GetAsync(predicate: x => x.Id == returnItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnItemResponse>(response);
            }
        }
    }
}
