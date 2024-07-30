using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants.StockContainerHierarchyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Create;

public class CreateStockContainerHierarchyCommand : IRequest<CreatedStockContainerHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockContainerHierarchies"];

    public CreateStockContainerHierarchyDto StockContainerHierarchy { get; set; }
    public StockContainerHierarchiesDetailLevel DetailLevel { get; set; }

    public class CreateStockContainerHierarchyCommandHandler : IRequestHandler<CreateStockContainerHierarchyCommand, CreatedStockContainerHierarchyResponse>
    {
        private readonly IStockContainerHierarchyRepository _stockContainerHierarchyRepository;
        private readonly StockContainerHierarchyBusinessRules _stockContainerHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockContainerHierarchyCommandHandler(IStockContainerHierarchyRepository stockContainerHierarchyRepository, IMapper mapper, StockContainerHierarchyBusinessRules stockContainerHierarchyBusinessRules)
        {
            _stockContainerHierarchyRepository = stockContainerHierarchyRepository;
            _mapper = mapper;
            _stockContainerHierarchyBusinessRules = stockContainerHierarchyBusinessRules;
        }

        public async Task<CreatedStockContainerHierarchyResponse> Handle(CreateStockContainerHierarchyCommand request, CancellationToken cancellationToken)
        {
            _stockContainerHierarchyBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            StockContainerHierarchy stockContainerHierarchy = _mapper.Map<StockContainerHierarchy>(request.StockContainerHierarchy);
            stockContainerHierarchy.Id = Guid.NewGuid();
            stockContainerHierarchy.CreatedDate = DateTime.Now;

            await _stockContainerHierarchyRepository.AddAsync(stockContainerHierarchy);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _stockContainerHierarchyRepository.GetAsync(predicate: x => x.Id == stockContainerHierarchy.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockContainerHierarchyResponse>(response);
            }
            else
            {
                var response = await _stockContainerHierarchyRepository.GetAsync(predicate: x => x.Id == stockContainerHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockContainerHierarchyResponse>(response);
            }
        }
    }
}
