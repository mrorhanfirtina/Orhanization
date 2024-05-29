using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants.StockInboundOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Queries.GetById;

public class GetByIdStockInboundQuery : IRequest<GetByIdStockInboundResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }

    public class GetByIdStockInboundQueryHandler : IRequestHandler<GetByIdStockInboundQuery, GetByIdStockInboundResponse>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockInboundQueryHandler(IStockInboundRepository stockInboundRepository, IMapper mapper, StockInboundBusinessRules stockInboundBusinessRules)
        {
            _stockInboundRepository = stockInboundRepository;
            _mapper = mapper;
            _stockInboundBusinessRules = stockInboundBusinessRules;
        }

        public async Task<GetByIdStockInboundResponse> Handle(GetByIdStockInboundQuery request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByIdStockInboundResponse>(await _stockInboundRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }
}
