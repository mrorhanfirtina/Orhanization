using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants.LogStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetById;

public class GetByIdLogStockQuery : IRequest<GetByIdLogStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdLogStockQueryHandler : IRequestHandler<GetByIdLogStockQuery, GetByIdLogStockResponse>
    {
        private readonly ILogStockRepository _logStockRepository;
        private readonly LogStockBusinessRules _logStockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLogStockQueryHandler(ILogStockRepository logStockRepository, IMapper mapper, LogStockBusinessRules logStockBusinessRules)
        {
            _logStockRepository = logStockRepository;
            _mapper = mapper;
            _logStockBusinessRules = logStockBusinessRules;
        }

        public async Task<GetByIdLogStockResponse> Handle(GetByIdLogStockQuery request, CancellationToken cancellationToken)
        {
            _logStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdLogStockResponse>(await _logStockRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(m => m.LogStockContainers).Include(m => m.LogStockAttributeValues)
                    .Include(m => m.LogStockReserveReasons).Include(m => m.LogStockUnsuitReasons),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

