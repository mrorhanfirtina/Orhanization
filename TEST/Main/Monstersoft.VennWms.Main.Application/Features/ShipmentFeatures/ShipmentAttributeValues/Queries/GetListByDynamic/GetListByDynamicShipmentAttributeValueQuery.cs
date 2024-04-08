using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Rules;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicShipmentAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicShipmentAttributeValueQueryHandler : IRequestHandler<GetListByDynamicShipmentAttributeValueQuery, GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto>>
    {
        private readonly IShipmentAttributeValueRepository _shipmentAttributeValueRepository;
        private readonly ShipmentAttributeValueBusinessRules _shipmentAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicShipmentAttributeValueQueryHandler(IShipmentAttributeValueRepository shipmentAttributeValueRepository, IMapper mapper, ShipmentAttributeValueBusinessRules shipmentAttributeValueBusinessRules)
        {
            _shipmentAttributeValueRepository = shipmentAttributeValueRepository;
            _shipmentAttributeValueBusinessRules = shipmentAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto>> Handle(GetListByDynamicShipmentAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _shipmentAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ShipmentAttributeValue> shipmentAttributeValueList = await _shipmentAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicShipmentAttributeValueListItemDto>>(shipmentAttributeValueList);
        }
    }

}
