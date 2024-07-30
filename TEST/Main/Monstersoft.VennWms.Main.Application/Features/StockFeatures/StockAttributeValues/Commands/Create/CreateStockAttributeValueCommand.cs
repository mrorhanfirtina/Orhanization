using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Commands.Create;

public class CreateStockAttributeValueCommand : IRequest<CreatedStockAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetStockAttributeValues"];


    public CreateStockAttributeValueDto StockAttributeValue { get; set; }
    public StockAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class CreateStockAttributeValueCommandHandler : IRequestHandler<CreateStockAttributeValueCommand, CreatedStockAttributeValueResponse>
    {
        private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
        private readonly StockAttributeValueBusinessRules _stockAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockAttributeValueCommandHandler(IStockAttributeValueRepository stockAttributeValueRepository, IMapper mapper, StockAttributeValueBusinessRules stockAttributeValueBusinessRules)
        {
            _stockAttributeValueRepository = stockAttributeValueRepository;
            _mapper = mapper;
            _stockAttributeValueBusinessRules = stockAttributeValueBusinessRules;
        }

        public async Task<CreatedStockAttributeValueResponse> Handle(CreateStockAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckStockAttributeIdExistence(request.StockAttributeValue.StockAttributeId)
                .CheckStockIdExistence(request.StockAttributeValue.StockId);

            StockAttributeValue stockAttributeValue = _mapper.Map<StockAttributeValue>(request.StockAttributeValue);
            stockAttributeValue.Id = Guid.NewGuid();
            stockAttributeValue.CreatedDate = DateTime.Now;

            await _stockAttributeValueRepository.AddAsync(stockAttributeValue);

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

                return _mapper.Map<CreatedStockAttributeValueResponse>(response);
            }
            else
            {
                var response = await _stockAttributeValueRepository.GetAsync(predicate: x => x.Id == stockAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStockAttributeValueResponse>(response);
            }
        }
    }
}

