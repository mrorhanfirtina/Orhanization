using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants.ContainerUnitOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetListByDynamic;

public class GetListByDynamicContainerUnitQuery : IRequest<GetListResponse<GetListByDynamicContainerUnitListItemDto>>, ITransactionalRequest,
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [ Admin, User, Read ];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicContainerUnitQueryHandler : IRequestHandler<GetListByDynamicContainerUnitQuery, GetListResponse<GetListByDynamicContainerUnitListItemDto>>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicContainerUnitQueryHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, ContainerUnitBusinessRules containerUnitBusinessRules)
        {
            _containerUnitRepository = containerUnitRepository;
            _containerUnitBusinessRules = containerUnitBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicContainerUnitListItemDto>> Handle(GetListByDynamicContainerUnitQuery request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ContainerUnit> containerUnitList = await _containerUnitRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicContainerUnitListItemDto>>(containerUnitList);
        }
    }

}

