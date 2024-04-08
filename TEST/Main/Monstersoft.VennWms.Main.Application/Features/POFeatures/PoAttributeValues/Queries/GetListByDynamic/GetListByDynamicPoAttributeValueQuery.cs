using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicPoAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicPoAttributeValueQueryHandler : IRequestHandler<GetListByDynamicPoAttributeValueQuery, GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPoAttributeValueQueryHandler(IPoAttributeValueRepository poAttributeValueRepository, IMapper mapper, PoAttributeValueBusinessRules poAttributeValueBusinessRules)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>> Handle(GetListByDynamicPoAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<PoAttributeValue> poAttributeValueList = await _poAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicPoAttributeValueListItemDto>>(poAttributeValueList);
        }
    }

}

