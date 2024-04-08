using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetById;

public class GetByIdStockQuery : IRequest<GetByIdStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockQueryHandler : IRequestHandler<GetByIdStockQuery, GetByIdStockResponse>
    {
        private readonly IStockRepository _stockRepository;
        private readonly StockBusinessRules _stockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockQueryHandler(IStockRepository stockRepository, IMapper mapper, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<GetByIdStockResponse> Handle(GetByIdStockQuery request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockResponse>(await _stockRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.StockContainer).Include(x => x.StockAttributeValues).Include(x => x.StockMemos).Include(x => x.StockReserveReasons).Include(x => x.StockUnsuitReasons),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

