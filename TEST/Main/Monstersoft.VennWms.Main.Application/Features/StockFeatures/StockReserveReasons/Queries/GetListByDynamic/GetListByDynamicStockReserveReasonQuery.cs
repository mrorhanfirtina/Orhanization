using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants.StockReserveReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetListByDynamic;

public class GetListByDynamicStockReserveReasonQuery : IRequest<GetListResponse<GetListByDynamicStockReserveReasonListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public StockReserveReasonsDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicStockReserveReasonQueryHandler : IRequestHandler<GetListByDynamicStockReserveReasonQuery, GetListResponse<GetListByDynamicStockReserveReasonListItemDto>>
    {
        private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
        private readonly StockReserveReasonBusinessRules _stockReserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStockReserveReasonQueryHandler(IStockReserveReasonRepository stockReserveReasonRepository, IMapper mapper, StockReserveReasonBusinessRules stockReserveReasonBusinessRules)
        {
            _stockReserveReasonRepository = stockReserveReasonRepository;
            _stockReserveReasonBusinessRules = stockReserveReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStockReserveReasonListItemDto>> Handle(GetListByDynamicStockReserveReasonQuery request, CancellationToken cancellationToken)
        {
            _stockReserveReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<StockReserveReason> stockReserveReasonList = await _stockReserveReasonRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockReserveReasonListItemDto>>(stockReserveReasonList);
            }
            else
            {
                Paginate<StockReserveReason> stockReserveReasonList = await _stockReserveReasonRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<StockReserveReason> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeReserveReason)
                    {
                        query = query.Include(y => y.ReserveReason);
                    }

                    var includableQuery = query as IIncludableQueryable<StockReserveReason, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicStockReserveReasonListItemDto>>(stockReserveReasonList);
            }
        }
    }
}

