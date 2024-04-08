using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants.StockMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Queries.GetById;

public class GetByIdStockMemoQuery : IRequest<GetByIdStockMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockMemoQueryHandler : IRequestHandler<GetByIdStockMemoQuery, GetByIdStockMemoResponse>
    {
        private readonly IStockMemoRepository _stockMemoRepository;
        private readonly StockMemoBusinessRules _stockMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockMemoQueryHandler(IStockMemoRepository stockMemoRepository, IMapper mapper, StockMemoBusinessRules stockMemoBusinessRules)
        {
            _stockMemoRepository = stockMemoRepository;
            _mapper = mapper;
            _stockMemoBusinessRules = stockMemoBusinessRules;
        }

        public async Task<GetByIdStockMemoResponse> Handle(GetByIdStockMemoQuery request, CancellationToken cancellationToken)
        {
            _stockMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockMemoResponse>(await _stockMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
