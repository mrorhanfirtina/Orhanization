using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetByCode;

public class GetByCodeStockAttributeQuery : IRequest<GetByCodeStockAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }



    public class GetByCodeStockAttributeQueryHandler : IRequestHandler<GetByCodeStockAttributeQuery, GetByCodeStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeStockAttributeQueryHandler(IStockAttributeRepository stockAttributeRepository, IMapper mapper, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _mapper = mapper;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
        }

        public async Task<GetByCodeStockAttributeResponse> Handle(GetByCodeStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeStockAttributeResponse>(await _stockAttributeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
