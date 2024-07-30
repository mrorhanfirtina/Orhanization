using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants.SerialLogOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Update;

public class UpdateSerialLogCommand : IRequest<UpdatedSerialLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, SerialLogOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerialLogs"];

    public UpdateSerialLogDto SerialLog { get; set; }
    public SerialLogsDetailLevel DetailLevel { get; set; }



    public class UpdateSerialLogCommandHandler : IRequestHandler<UpdateSerialLogCommand, UpdatedSerialLogResponse>
    {
        private readonly ISerialLogRepository _serialLogRepository;
        private readonly SerialLogBusinessRules _serialLogBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSerialLogCommandHandler(ISerialLogRepository serialLogRepository, SerialLogBusinessRules serialLogBusinessRules, IMapper mapper)
        {
            _serialLogRepository = serialLogRepository;
            _serialLogBusinessRules = serialLogBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedSerialLogResponse> Handle(UpdateSerialLogCommand request, CancellationToken cancellationToken)
        {
            _serialLogBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.SerialLog.Id);


            SerialLog? currentSerialLog = await _serialLogRepository.GetAsync(predicate: x => x.Id == request.SerialLog.Id);

            SerialLog? serialLog = _mapper.Map(request.SerialLog, currentSerialLog);
            serialLog.UpdatedDate = DateTime.Now;

            await _serialLogRepository.UpdateAsync(serialLog);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _serialLogRepository.GetAsync(predicate: x => x.Id == serialLog.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSerialLogResponse>(response);
            }
            else
            {
                var response = await _serialLogRepository.GetAsync(predicate: x => x.Id == serialLog.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSerialLogResponse>(response);
            }
        }
    }
}
