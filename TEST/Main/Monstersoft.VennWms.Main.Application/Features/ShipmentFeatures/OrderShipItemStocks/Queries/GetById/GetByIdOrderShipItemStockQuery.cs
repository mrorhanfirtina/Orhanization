using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants.OrderShipItemStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Queries.GetById;

public class GetByIdOrderShipItemStockQuery : IRequest<GetByIdOrderShipItemStockResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderShipItemStockQueryHandler : IRequestHandler<GetByIdOrderShipItemStockQuery, GetByIdOrderShipItemStockResponse>
    {
        private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
        private readonly OrderShipItemStockBusinessRules _orderShipItemStockBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderShipItemStockQueryHandler(IOrderShipItemStockRepository orderShipItemStockRepository, IMapper mapper, OrderShipItemStockBusinessRules orderShipItemStockBusinessRules)
        {
            _orderShipItemStockRepository = orderShipItemStockRepository;
            _mapper = mapper;
            _orderShipItemStockBusinessRules = orderShipItemStockBusinessRules;
        }

        public async Task<GetByIdOrderShipItemStockResponse> Handle(GetByIdOrderShipItemStockQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemStockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderShipItemStockResponse>(await _orderShipItemStockRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

