using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetById;

public class GetByIdReturnQuery : IRequest<GetByIdReturnResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnsDetailLevel? DetailLevel { get; set; }


    public class GetByIdReturnQueryHandler : IRequestHandler<GetByIdReturnQuery, GetByIdReturnResponse>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<GetByIdReturnResponse> Handle(GetByIdReturnQuery request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnResponse>(await _returnRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<Return> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturnMemo)
                    {
                        query = query.Include(y => y.ReturnMemos);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludeCustomer)
                    {
                        query = query.Include(y => y.Customer);

                        var customerDetailLevel = detailLevel.CustomerDetailLevel;

                        if (customerDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Customer.Address);
                        }

                        if (customerDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Customer.Company);
                        }
                    }

                    if (detailLevel.IncludeReturnType)
                    {
                        query = query.Include(y => y.ReturnType);
                    }

                    if (detailLevel.IncludeReturnAttributeValue)
                    {
                        query = query.Include(y => y.ReturnAttributeValues);

                        var returnAttributeValueDetailLevel = detailLevel.ReturnAttributeValueDetailLevel;

                        if (returnAttributeValueDetailLevel.IncludeReturnAttribute)
                        {
                            query = query.Include(y => y.ReturnAttributeValues).ThenInclude(y => y.ReturnAttribute);

                            var returnAttributeDetailLevel = returnAttributeValueDetailLevel.ReturnAttributeDetailLevel;

                            if (returnAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ReturnAttributeValues).ThenInclude(y => y.ReturnAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeReturnItem)
                    {
                        query = query.Include(y => y.ReturnItems);

                        var returnItemDetailLevel = detailLevel.ReturnItemDetailLevel;

                        if (returnItemDetailLevel.IncludeReturnItemMemo)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItemMemos);
                        }

                        if (returnItemDetailLevel.IncludeStatus)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.Status);
                        }

                        if (returnItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.Product);
                        }

                        if (returnItemDetailLevel.IncludeReturnItmStockAttrValue)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues);

                            var returnItmStockAttrValueDetailLevel = returnItemDetailLevel.ReturnItmStockAttrValueDetailLevel;

                            if (returnItmStockAttrValueDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                                var stockAttributeDetailLevel = returnItmStockAttrValueDetailLevel.StockAttributeDetailLevel;

                                if (stockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                                }
                            }
                        }

                        if (returnItemDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ItemUnit);

                            var itemUnitDetailLevel = returnItemDetailLevel.ItemUnitDetailLevel;

                            if (itemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.ReturnItems).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Return, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnResponse>(await _returnRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
