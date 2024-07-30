using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;

public class UpdateReturnItmStockAttrValueCommand : IRequest<UpdatedReturnItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnItemStockAttrValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItmStockAttrValues"];

    public UpdateReturnItmStockAttrValueDto ReturnItmStockAttrValue { get; set; }
    public ReturnItmStockAttrValuesDetailLevel? DetailLevel { get; set; }


    public class UpdateReturnItmStockAttrValueCommandHandler : IRequestHandler<UpdateReturnItmStockAttrValueCommand, UpdatedReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnItmStockAttrValueCommandHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules, IMapper mapper)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnItmStockAttrValueResponse> Handle(UpdateReturnItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnItmStockAttrValue.Id)
            .CheckReturnItemIdExistence(request.ReturnItmStockAttrValue.ReturnItemId)
            .CheckStockAttributeIdExistence(request.ReturnItmStockAttrValue.StockAttributeId);

            ReturnItmStockAttrValue? currentReturnItmStockAttrValue = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.ReturnItmStockAttrValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnItmStockAttrValue? returnItmStockAttrValue = _mapper.Map(request.ReturnItmStockAttrValue, currentReturnItmStockAttrValue);
            returnItmStockAttrValue.UpdatedDate = DateTime.Now;

            await _returnItmStockAttrValueRepository.UpdateAsync(returnItmStockAttrValue);

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

                return _mapper.Map<UpdatedReturnItmStockAttrValueResponse>(response);
            }
            else
            {
                var response = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == returnItmStockAttrValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnItmStockAttrValueResponse>(response);
            }
        }
    }
}

