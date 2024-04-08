using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Queries.GetById;

public class GetByIdStockPackTypeQuery : IRequest<GetByIdStockPackTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockPackTypeQueryHandler : IRequestHandler<GetByIdStockPackTypeQuery, GetByIdStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockPackTypeQueryHandler(IStockPackTypeRepository stockPackTypeRepository, IMapper mapper, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _mapper = mapper;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
        }

        public async Task<GetByIdStockPackTypeResponse> Handle(GetByIdStockPackTypeQuery request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockPackTypeResponse>(await _stockPackTypeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

