using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetById;

public class GetByIdReturnItmStockAttrValueQuery : IRequest<GetByIdReturnItmStockAttrValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnItmStockAttrValuesDetailLevel? DetailLevel { get; set; }

    public class GetByIdReturnItmStockAttrValueQueryHandler : IRequestHandler<GetByIdReturnItmStockAttrValueQuery, GetByIdReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItmStockAttrValueQueryHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _mapper = mapper;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
        }

        public async Task<GetByIdReturnItmStockAttrValueResponse> Handle(GetByIdReturnItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnItmStockAttrValueResponse>(await _returnItmStockAttrValueRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnItmStockAttrValueResponse>(await _returnItmStockAttrValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

