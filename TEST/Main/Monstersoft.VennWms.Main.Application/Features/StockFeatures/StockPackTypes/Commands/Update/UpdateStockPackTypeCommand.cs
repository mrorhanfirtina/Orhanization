using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Update;

public class UpdateStockPackTypeCommand : IRequest<UpdatedStockPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockPackTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockPackTypes"];

    public UpdateStockPackTypeDto StockPackType { get; set; }
    public StockPackTypesDetailLevel? DetailLevel { get; set; }


    public class UpdateStockPackTypeCommandHandler : IRequestHandler<UpdateStockPackTypeCommand, UpdatedStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockPackTypeCommandHandler(IStockPackTypeRepository stockPackTypeRepository, StockPackTypeBusinessRules stockPackTypeBusinessRules, IMapper mapper)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockPackTypeResponse> Handle(UpdateStockPackTypeCommand request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockPackType.Id)
            .CheckItemUnitIdExistence(request.StockPackType.ItemUnitId)
            .CheckStockIdExistence(request.StockPackType.StockId);

            StockPackType? currentStockPackType = await _stockPackTypeRepository.GetAsync(predicate: x => x.Id == request.StockPackType.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockPackType? stockPackType = _mapper.Map(request.StockPackType, currentStockPackType);
            stockPackType.UpdatedDate = DateTime.Now;

            await _stockPackTypeRepository.UpdateAsync(stockPackType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _stockPackTypeRepository.GetAsync(predicate: x => x.Id == stockPackType.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockPackTypeResponse>(response);
            }
            else
            {
                var response = await _stockPackTypeRepository.GetAsync(predicate: x => x.Id == stockPackType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockPackTypeResponse>(response);
            }
        }
    }
}

