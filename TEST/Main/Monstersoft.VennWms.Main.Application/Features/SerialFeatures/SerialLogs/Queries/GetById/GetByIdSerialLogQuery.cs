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
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants.SerialLogOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetById;

public class GetByIdSerialLogQuery : IRequest<GetByIdSerialLogResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public SerialLogsDetailLevel DetailLevel { get; set; }



    public class GetByIdSerialLogQueryHandler : IRequestHandler<GetByIdSerialLogQuery, GetByIdSerialLogResponse>
    {
        private readonly ISerialLogRepository _serialLogRepository;
        private readonly SerialLogBusinessRules _serialLogBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSerialLogQueryHandler(ISerialLogRepository serialLogRepository, IMapper mapper, SerialLogBusinessRules serialLogBusinessRules)
        {
            _serialLogRepository = serialLogRepository;
            _mapper = mapper;
            _serialLogBusinessRules = serialLogBusinessRules;
        }

        public async Task<GetByIdSerialLogResponse> Handle(GetByIdSerialLogQuery request, CancellationToken cancellationToken)
        {
            _serialLogBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdSerialLogResponse>(await _serialLogRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdSerialLogResponse>(await _serialLogRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
