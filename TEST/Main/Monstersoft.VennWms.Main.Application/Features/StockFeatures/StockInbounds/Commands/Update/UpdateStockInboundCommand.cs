using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;

public class UpdateStockInboundCommand : IRequest<UpdatedStockInboundResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, StockInboundOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockInbounds";

    public UpdateStockInboundDto StockInbound { get; set; }
    public StockInboundsDetailLevel? DetailLevel { get; set; }

    public class UpdateStockInboundCommandHandler : IRequestHandler<UpdateStockInboundCommand, UpdatedStockInboundResponse>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockInboundCommandHandler(IStockInboundRepository stockInboundRepository, StockInboundBusinessRules stockInboundBusinessRules, IMapper mapper)
        {
            _stockInboundRepository = stockInboundRepository;
            _stockInboundBusinessRules = stockInboundBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockInboundResponse> Handle(UpdateStockInboundCommand request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            StockInbound? currentStockInbound = await _stockInboundRepository.GetAsync(predicate: x => x.Id == request.StockInbound.Id);

            StockInbound? stockInbound = _mapper.Map(request.StockInbound, currentStockInbound);
            stockInbound.UpdatedDate = DateTime.Now;

            await _stockInboundRepository.UpdateAsync(stockInbound);

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

                return _mapper.Map<UpdatedStockInboundResponse>(response);
            }
            else
            {
                var response = await _stockInboundRepository.GetAsync(predicate: x => x.Id == stockInbound.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockInboundResponse>(response);
            }
        }
    }
}
