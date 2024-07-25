using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Create;

public class CreateReturnItmStockAttrValueCommand : IRequest<CreatedReturnItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItmStockAttrValues"];


    public CreateReturnItmStockAttrValueDto ReturnItmStockAttrValue { get; set; }
    public ReturnItmStockAttrValuesDetailLevel? DetailLevel { get; set; }


    public class CreateReturnItmStockAttrValueCommandHandler : IRequestHandler<CreateReturnItmStockAttrValueCommand, CreatedReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnItmStockAttrValueCommandHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _mapper = mapper;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
        }

        public async Task<CreatedReturnItmStockAttrValueResponse> Handle(CreateReturnItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnItemIdExistence(request.ReturnItmStockAttrValue.ReturnItemId)
                .CheckStockAttributeIdExistence(request.ReturnItmStockAttrValue.StockAttributeId);

            ReturnItmStockAttrValue returnItmStockAttrValue = _mapper.Map<ReturnItmStockAttrValue>(request.ReturnItmStockAttrValue);
            returnItmStockAttrValue.Id = Guid.NewGuid();
            returnItmStockAttrValue.CreatedDate = DateTime.Now;

            await _returnItmStockAttrValueRepository.AddAsync(returnItmStockAttrValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == returnItmStockAttrValue.Id,
                include: x =>
                {
                    IQueryable<ReturnItmStockAttrValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturnItem)
                    {
                        query = query.Include(y => y.ReturnItem);

                        var returnItemDetailLevel = detailLevel.ReturnItemDetailLevel;

                        if (returnItemDetailLevel.IncludeReturn)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Return);
                        }

                        if (returnItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Product);
                        }
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        var stockAttributeDetailLevel = detailLevel.StockAttributeDetailLevel;

                        if (stockAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnItmStockAttrValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnItmStockAttrValueResponse>(response);
            }
            else
            {
                var response = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == returnItmStockAttrValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnItmStockAttrValueResponse>(response);
            }
        }
    }
}

