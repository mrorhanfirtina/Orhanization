using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetByCode;

public class GetByCodeOrderShipmentQuery : IRequest<GetByCodeOrderShipmentResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }

    public class GetByCodeOrderShipmentQueryHandler : IRequestHandler<GetByCodeOrderShipmentQuery, GetByCodeOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeOrderShipmentQueryHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<GetByCodeOrderShipmentResponse> Handle(GetByCodeOrderShipmentQuery request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeOrderShipmentResponse>(await _orderShipmentRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.OrderShipItems).ThenInclude(os => os.OrderShipItemTasks).ThenInclude(ot => ot.OrderShipItemStocks),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
