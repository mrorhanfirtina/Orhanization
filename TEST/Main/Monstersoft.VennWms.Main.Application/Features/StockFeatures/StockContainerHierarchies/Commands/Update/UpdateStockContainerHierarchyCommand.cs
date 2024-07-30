using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Commands.Update;

public class UpdateStockContainerHierarchyCommand : IRequest<UpdatedStockContainerHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockContainerHierarchyOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockContainerHierarchies"];

    public UpdateStockContainerHierarchyDto StockContainerHierarchy { get; set; }
    public StockContainerHierarchiesDetailLevel DetailLevel { get; set; }



    public class UpdateStockContainerHierarchyCommandHandler : IRequestHandler<UpdateStockContainerHierarchyCommand, UpdatedStockContainerHierarchyResponse>
    {
        private readonly IStockContainerHierarchyRepository _stockContainerHierarchyRepository;
        private readonly StockContainerHierarchyBusinessRules _stockContainerHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockContainerHierarchyCommandHandler(IStockContainerHierarchyRepository stockContainerHierarchyRepository, StockContainerHierarchyBusinessRules stockContainerHierarchyBusinessRules, IMapper mapper)
        {
            _stockContainerHierarchyRepository = stockContainerHierarchyRepository;
            _stockContainerHierarchyBusinessRules = stockContainerHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockContainerHierarchyResponse> Handle(UpdateStockContainerHierarchyCommand request, CancellationToken cancellationToken)
        {
            _stockContainerHierarchyBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockContainerHierarchy.Id);


            StockContainerHierarchy? currentStockContainerHierarchy = await _stockContainerHierarchyRepository.GetAsync(predicate: x => x.Id == request.StockContainerHierarchy.Id);

            StockContainerHierarchy? stockContainerHierarchy = _mapper.Map(request.StockContainerHierarchy, currentStockContainerHierarchy);
            stockContainerHierarchy.UpdatedDate = DateTime.Now;

            await _stockContainerHierarchyRepository.UpdateAsync(stockContainerHierarchy);

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

                return _mapper.Map<UpdatedStockContainerHierarchyResponse>(response);
            }
            else
            {
                var response = await _stockContainerHierarchyRepository.GetAsync(predicate: x => x.Id == stockContainerHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockContainerHierarchyResponse>(response);
            }
        }
    }
}
