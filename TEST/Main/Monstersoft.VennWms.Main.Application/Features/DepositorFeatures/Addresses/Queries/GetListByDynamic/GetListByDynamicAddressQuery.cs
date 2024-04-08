using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Constants.AddressOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Queries.GetListByDynamic;

public class GetListByDynamicAddressQuery : IRequest<GetListResponse<GetListByDynamicAddressListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicAddressQueryHandler : IRequestHandler<GetListByDynamicAddressQuery, GetListResponse<GetListByDynamicAddressListItemDto>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly AddressBusinessRules _addressBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper, AddressBusinessRules addressBusinessRules)
        {
            _addressRepository = addressRepository;
            _addressBusinessRules = addressBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicAddressListItemDto>> Handle(GetListByDynamicAddressQuery request, CancellationToken cancellationToken)
        {
            _addressBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Address> addressList = await _addressRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicAddressListItemDto>>(addressList);
        }
    }

}

