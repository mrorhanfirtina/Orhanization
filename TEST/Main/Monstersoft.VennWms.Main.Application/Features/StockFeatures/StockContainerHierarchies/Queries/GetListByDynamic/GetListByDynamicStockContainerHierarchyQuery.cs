using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants.StockContainerHierarchyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Queries.GetListByDynamic;

public class GetListByDynamicStockContainerHierarchyQuery : IRequest<GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public StockContainerHierarchiesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicStockContainerHierarchyQueryHandler : IRequestHandler<GetListByDynamicStockContainerHierarchyQuery, GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>>
    {
        private readonly IStockContainerHierarchyRepository _stockContainerHierarchyRepository;
        private readonly StockContainerHierarchyBusinessRules _stockContainerHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockContainerHierarchyQueryHandler(IStockContainerHierarchyRepository stockContainerHierarchyRepository, IMapper mapper, StockContainerHierarchyBusinessRules stockContainerHierarchyBusinessRules)
        {
            _stockContainerHierarchyRepository = stockContainerHierarchyRepository;
            _stockContainerHierarchyBusinessRules = stockContainerHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>> Handle(GetListByDynamicStockContainerHierarchyQuery request, CancellationToken cancellationToken)
        {
            _stockContainerHierarchyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<StockContainerHierarchy> stockContainerHierarchyList = await _stockContainerHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<StockContainerHierarchy> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeParentContainer)
                    {
                        query = query.Include(x => x.ParentContainer);

                        if (detailLevel.ParentContainerDetailLevel.IncludeContainerUnit)
                        {
                            query = query.Include(x => x.ParentContainer).ThenInclude(y => y.ContainerUnit);
                        }

                        if (detailLevel.ParentContainerDetailLevel.IncludeStock)
                        {
                            query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks);

                            if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.IncludeDepositor)
                            {
                                query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Depositor);
                            }

                            if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.IncludeLocation)
                            {
                                query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Location);
                            }

                            if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.IncludeProduct)
                            {
                                query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Product);
                            }

                            if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.IncludeDepositorCompany)
                            {
                                query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.DepositorCompany);
                            }

                            if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.IncludeCuItemUnit)
                            {
                                query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.CuItemUnit);

                                if (detailLevel.ParentContainerDetailLevel.ParentStockDetailLevel.ParentUnitDetailLevel.IncludeUnit)
                                {
                                    query = query.Include(x => x.ParentContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.CuItemUnit).ThenInclude(a => a.Unit);
                                }
                            }
                        }
                    }

                    if (detailLevel.IncludeChildContainer)
                    {
                        query = query.Include(x => x.ChildContainer);

                        if (detailLevel.ChildContainerDetailLevel.IncludeContainerUnit)
                        {
                            query = query.Include(x => x.ChildContainer).ThenInclude(y => y.ContainerUnit);
                        }

                        if (detailLevel.ChildContainerDetailLevel.IncludeStock)
                        {
                            query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks);

                            if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.IncludeDepositor)
                            {
                                query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Depositor);
                            }

                            if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.IncludeLocation)
                            {
                                query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Location);
                            }

                            if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.IncludeProduct)
                            {
                                query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.Product);
                            }

                            if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.IncludeDepositorCompany)
                            {
                                query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.DepositorCompany);
                            }

                            if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.IncludeCuItemUnit)
                            {
                                query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.CuItemUnit);

                                if (detailLevel.ChildContainerDetailLevel.ChildStockDetailLevel.ChildUnitDetailLevel.IncludeUnit)
                                {
                                    query = query.Include(x => x.ChildContainer).ThenInclude(y => y.Stocks).ThenInclude(z => z.CuItemUnit).ThenInclude(a => a.Unit);
                                }
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<StockContainerHierarchy, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>>(stockContainerHierarchyList);
            }
            else
            {
                Paginate<StockContainerHierarchy> stockContainerHierarchyList = await _stockContainerHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockContainerHierarchyListItemDto>>(stockContainerHierarchyList);
            }
        }
    }
}
