using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants.StockInboundOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;

public class CreateStockInboundCommand : IRequest<CreatedStockInboundResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockInbounds";

    public CreateStockInboundDto StockInbound { get; set; }
    public StockInboundsDetailLevel? DetailLevel { get; set; }


    public class CreateStockInboundCommandHandler : IRequestHandler<CreateStockInboundCommand, CreatedStockInboundResponse>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockInboundCommandHandler(IStockInboundRepository stockInboundRepository, IMapper mapper, StockInboundBusinessRules stockInboundBusinessRules)
        {
            _stockInboundRepository = stockInboundRepository;
            _mapper = mapper;
            _stockInboundBusinessRules = stockInboundBusinessRules;
        }

        public async Task<CreatedStockInboundResponse> Handle(CreateStockInboundCommand request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            StockInbound stockInbound = _mapper.Map<StockInbound>(request.StockInbound);
            stockInbound.Id = Guid.NewGuid();
            stockInbound.CreatedDate = DateTime.Now;

            await _stockInboundRepository.AddAsync(stockInbound);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _stockInboundRepository.GetAsync(predicate: x => x.Id == stockInbound.Id,
                include: x =>
                {
                    IQueryable<StockInbound> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipt);
                    }

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.CuItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.CuItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockInbound, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockInboundResponse>(response);
            }
            else
            {
                var response = await _stockInboundRepository.GetAsync(predicate: x => x.Id == stockInbound.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockInboundResponse>(response);
            }
        }
    }
}
