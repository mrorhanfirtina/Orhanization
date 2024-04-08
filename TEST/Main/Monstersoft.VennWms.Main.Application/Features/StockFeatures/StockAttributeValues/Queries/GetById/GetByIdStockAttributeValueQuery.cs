using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants.StockAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetById;

public class GetByIdStockAttributeValueQuery : IRequest<GetByIdStockAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockAttributeValueQueryHandler : IRequestHandler<GetByIdStockAttributeValueQuery, GetByIdStockAttributeValueResponse>
    {
        private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
        private readonly StockAttributeValueBusinessRules _stockAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockAttributeValueQueryHandler(IStockAttributeValueRepository stockAttributeValueRepository, IMapper mapper, StockAttributeValueBusinessRules stockAttributeValueBusinessRules)
        {
            _stockAttributeValueRepository = stockAttributeValueRepository;
            _mapper = mapper;
            _stockAttributeValueBusinessRules = stockAttributeValueBusinessRules;
        }

        public async Task<GetByIdStockAttributeValueResponse> Handle(GetByIdStockAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockAttributeValueResponse>(await _stockAttributeValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

