using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;

public class GetByIdReturnItemQuery : IRequest<GetByIdReturnItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnItemsDetailLevel? DetailLevel { get; set; }


    public class GetByIdReturnItemQueryHandler : IRequestHandler<GetByIdReturnItemQuery, GetByIdReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItemQueryHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _mapper = mapper;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<GetByIdReturnItemResponse> Handle(GetByIdReturnItemQuery request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnItemResponse>(await _returnItemRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnItemResponse>(await _returnItemRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
