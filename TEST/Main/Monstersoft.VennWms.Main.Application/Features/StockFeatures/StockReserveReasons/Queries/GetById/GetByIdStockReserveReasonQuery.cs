using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants.StockReserveReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Queries.GetById;

public class GetByIdStockReserveReasonQuery : IRequest<GetByIdStockReserveReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockReserveReasonQueryHandler : IRequestHandler<GetByIdStockReserveReasonQuery, GetByIdStockReserveReasonResponse>
    {
        private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
        private readonly StockReserveReasonBusinessRules _stockReserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockReserveReasonQueryHandler(IStockReserveReasonRepository stockReserveReasonRepository, IMapper mapper, StockReserveReasonBusinessRules stockReserveReasonBusinessRules)
        {
            _stockReserveReasonRepository = stockReserveReasonRepository;
            _mapper = mapper;
            _stockReserveReasonBusinessRules = stockReserveReasonBusinessRules;
        }

        public async Task<GetByIdStockReserveReasonResponse> Handle(GetByIdStockReserveReasonQuery request, CancellationToken cancellationToken)
        {
            _stockReserveReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockReserveReasonResponse>(await _stockReserveReasonRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

