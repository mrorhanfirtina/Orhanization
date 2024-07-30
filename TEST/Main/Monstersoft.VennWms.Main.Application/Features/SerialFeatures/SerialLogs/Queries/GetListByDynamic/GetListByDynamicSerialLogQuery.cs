using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants.SerialLogOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetListByDynamic;

public class GetListByDynamicSerialLogQuery : IRequest<GetListResponse<GetListByDynamicSerialLogListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public SerialLogsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicSerialLogQueryHandler : IRequestHandler<GetListByDynamicSerialLogQuery, GetListResponse<GetListByDynamicSerialLogListItemDto>>
    {
        private readonly ISerialLogRepository _serialLogRepository;
        private readonly SerialLogBusinessRules _serialLogBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSerialLogQueryHandler(ISerialLogRepository serialLogRepository, IMapper mapper, SerialLogBusinessRules serialLogBusinessRules)
        {
            _serialLogRepository = serialLogRepository;
            _serialLogBusinessRules = serialLogBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSerialLogListItemDto>> Handle(GetListByDynamicSerialLogQuery request, CancellationToken cancellationToken)
        {
            _serialLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<SerialLog> serialLogList = await _serialLogRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<SerialLog> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeTransactionType)
                    {
                        query = query.Include(x => x.TransactionType);
                    }

                    if (detailLevel.IncludeTransactionLog)
                    {
                        query = query.Include(x => x.TransactionLog);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(x => x.Depositor);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(x => x.Receipt);
                    }

                    var includableQuery = query as IIncludableQueryable<SerialLog, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialLogListItemDto>>(serialLogList);
            }
            else
            {
                Paginate<SerialLog> serialLogList = await _serialLogRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialLogListItemDto>>(serialLogList);
            }
        }
    }
}
