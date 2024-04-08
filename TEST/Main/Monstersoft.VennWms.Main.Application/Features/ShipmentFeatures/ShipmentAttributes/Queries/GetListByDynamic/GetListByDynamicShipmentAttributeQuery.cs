using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants.ShipmentAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Queries.GetListByDynamic;

public class GetListByDynamicShipmentAttributeQuery : IRequest<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicShipmentAttributeQueryHandler : IRequestHandler<GetListByDynamicShipmentAttributeQuery, GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>
    {
        private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
        private readonly ShipmentAttributeBusinessRules _shipmentAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicShipmentAttributeQueryHandler(IShipmentAttributeRepository shipmentAttributeRepository, IMapper mapper, ShipmentAttributeBusinessRules shipmentAttributeBusinessRules)
        {
            _shipmentAttributeRepository = shipmentAttributeRepository;
            _shipmentAttributeBusinessRules = shipmentAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>> Handle(GetListByDynamicShipmentAttributeQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ShipmentAttribute> shipmentAttributeList = await _shipmentAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicShipmentAttributeListItemDto>>(shipmentAttributeList);
        }
    }
}
