using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants.LocationProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductAttributeQuery : IRequest<GetListResponse<GetListByDynamicLocationProductAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLocationProductAttributeQueryHandler : IRequestHandler<GetListByDynamicLocationProductAttributeQuery, GetListResponse<GetListByDynamicLocationProductAttributeListItemDto>>
    {
        private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
        private readonly LocationProductAttributeBusinessRules _locationProductAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationProductAttributeQueryHandler(ILocationProductAttributeRepository locationProductAttributeRepository, IMapper mapper, LocationProductAttributeBusinessRules locationProductAttributeBusinessRules)
        {
            _locationProductAttributeRepository = locationProductAttributeRepository;
            _locationProductAttributeBusinessRules = locationProductAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationProductAttributeListItemDto>> Handle(GetListByDynamicLocationProductAttributeQuery request, CancellationToken cancellationToken)
        {
            _locationProductAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<LocationProductAttribute> locationProductAttributeList = await _locationProductAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLocationProductAttributeListItemDto>>(locationProductAttributeList);
        }
    }
}

