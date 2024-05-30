using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetById;

public class GetByIdStockPackTypeQuery : IRequest<GetByIdStockPackTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public StockPackTypesDetailLevel? DetailLevel { get; set; }


    public class GetByIdStockPackTypeQueryHandler : IRequestHandler<GetByIdStockPackTypeQuery, GetByIdStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockPackTypeQueryHandler(IStockPackTypeRepository stockPackTypeRepository, IMapper mapper, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _mapper = mapper;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
        }

        public async Task<GetByIdStockPackTypeResponse> Handle(GetByIdStockPackTypeQuery request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdStockPackTypeResponse>(await _stockPackTypeRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<StockPackType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);

                        var stockDetailLevel = detailLevel.StockDetailLevel;

                        if (stockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Product);
                        }

                        if (stockDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.DepositorCompany);
                        }

                        if (stockDetailLevel.IncludeLocation)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Location);
                        }

                        if (stockDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.Depositor);

                            var depositorDetailLevel = stockDetailLevel.DepositorDetailLevel;

                            if (depositorDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.Stock).ThenInclude(m => m.Depositor).ThenInclude(m => m.Company);
                            }
                        }

                        if (stockDetailLevel.IncludeCuItemUnit)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(m => m.CuItemUnit);

                            var cuItemUnitDetailLevel = stockDetailLevel.ItemUnitDetailLevel;

                            if (cuItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.Stock).ThenInclude(m => m.CuItemUnit).ThenInclude(m => m.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockPackType, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdStockPackTypeResponse>(await _stockPackTypeRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

