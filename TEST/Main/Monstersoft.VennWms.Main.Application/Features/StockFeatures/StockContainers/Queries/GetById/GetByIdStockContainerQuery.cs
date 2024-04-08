using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants.StockContainerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Queries.GetById;

public class GetByIdStockContainerQuery : IRequest<GetByIdStockContainerResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStockContainerQueryHandler : IRequestHandler<GetByIdStockContainerQuery, GetByIdStockContainerResponse>
    {
        private readonly IStockContainerRepository _stockContainerRepository;
        private readonly StockContainerBusinessRules _stockContainerBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockContainerQueryHandler(IStockContainerRepository stockContainerRepository, IMapper mapper, StockContainerBusinessRules stockContainerBusinessRules)
        {
            _stockContainerRepository = stockContainerRepository;
            _mapper = mapper;
            _stockContainerBusinessRules = stockContainerBusinessRules;
        }

        public async Task<GetByIdStockContainerResponse> Handle(GetByIdStockContainerQuery request, CancellationToken cancellationToken)
        {
            _stockContainerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStockContainerResponse>(await _stockContainerRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
