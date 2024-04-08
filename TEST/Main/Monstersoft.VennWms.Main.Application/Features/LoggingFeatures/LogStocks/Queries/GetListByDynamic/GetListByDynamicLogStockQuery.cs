using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetListByDynamic;

public class GetListByDynamicLogStockQuery : IRequest<GetListResponse<GetListByDynamicLogStockListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLogStockQueryHandler : IRequestHandler<GetListByDynamicLogStockQuery, GetListResponse<GetListByDynamicLogStockListItemDto>>
    {
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLogStockQueryHandler(ILogStockRepository logStockRepository, IMapper mapper, LogStockBusinessRules logStockBusinessRules)
        {
            _logStockRepository = logStockRepository;
            _logStockBusinessRules = logStockBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLogStockListItemDto>> Handle(GetListByDynamicLogStockQuery request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<LogStock> logStockList = await _logStockRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            include: m => m.Include(m => m.LogStockContainers).Include(m => m.LogStockAttributeValues)
                .Include(m => m.LogStockReserveReasons).Include(m => m.LogStockUnsuitReasons),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLogStockListItemDto>>(logStockList);
        }
    }
}

