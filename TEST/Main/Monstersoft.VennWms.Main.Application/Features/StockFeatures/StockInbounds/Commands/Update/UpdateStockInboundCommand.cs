using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants.StockInboundOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Commands.Update;

public class UpdateStockInboundCommand : IRequest<UpdatedStockInboundResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, StockInboundOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockInbounds";

    public UpdateStockInboundDto StockInbound { get; set; }

    public class UpdateStockInboundCommandHandler : IRequestHandler<UpdateStockInboundCommand, UpdatedStockInboundResponse>
    {
        private readonly IStockInboundRepository _stockInboundRepository;
        private readonly StockInboundBusinessRules _stockInboundBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockInboundCommandHandler(IStockInboundRepository stockInboundRepository, StockInboundBusinessRules stockInboundBusinessRules, IMapper mapper)
        {
            _stockInboundRepository = stockInboundRepository;
            _stockInboundBusinessRules = stockInboundBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockInboundResponse> Handle(UpdateStockInboundCommand request, CancellationToken cancellationToken)
        {
            _stockInboundBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            StockInbound? currentStockInbound = await _stockInboundRepository.GetAsync(predicate: x => x.Id == request.StockInbound.Id);

            StockInbound? stockInbound = _mapper.Map(request.StockInbound, currentStockInbound);
            stockInbound.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedStockInboundResponse>(await _stockInboundRepository.UpdateAsync(stockInbound));
        }
    }
}
