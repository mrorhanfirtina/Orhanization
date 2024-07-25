using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants.StockAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Update;

public class UpdateStockAttributeValueCommand : IRequest<UpdatedStockAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockAttributeValues"];

    public UpdateStockAttributeValueDto StockAttributeValue { get; set; }
    public StockAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class UpdateStockAttributeValueCommandHandler : IRequestHandler<UpdateStockAttributeValueCommand, UpdatedStockAttributeValueResponse>
    {
        private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
        private readonly StockAttributeValueBusinessRules _stockAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockAttributeValueCommandHandler(IStockAttributeValueRepository stockAttributeValueRepository, StockAttributeValueBusinessRules stockAttributeValueBusinessRules, IMapper mapper)
        {
            _stockAttributeValueRepository = stockAttributeValueRepository;
            _stockAttributeValueBusinessRules = stockAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockAttributeValueResponse> Handle(UpdateStockAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockAttributeValue.Id)
            .CheckStockAttributeIdExistence(request.StockAttributeValue.StockAttributeId)
            .CheckStockIdExistence(request.StockAttributeValue.StockId);

            StockAttributeValue? currentStockAttributeValue = await _stockAttributeValueRepository.GetAsync(predicate: x => x.Id == request.StockAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockAttributeValue? stockAttributeValue = _mapper.Map(request.StockAttributeValue, currentStockAttributeValue);
            stockAttributeValue.UpdatedDate = DateTime.Now;

            await _stockAttributeValueRepository.UpdateAsync(stockAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _stockAttributeValueRepository.GetAsync(predicate: x => x.Id == stockAttributeValue.Id,
                include: x =>
                {
                    IQueryable<StockAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        if (detailLevel.TargetDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<StockAttributeValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockAttributeValueResponse>(response);
            }
            else
            {
                var response = await _stockAttributeValueRepository.GetAsync(predicate: x => x.Id == stockAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockAttributeValueResponse>(response);
            }
        }
    }
}

