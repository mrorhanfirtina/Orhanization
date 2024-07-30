using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants.ContainerUnitOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetList;

public class GetListContainerUnitQuery : IRequest<GetListResponse<GetListContainerUnitListItemDto>>, ICachableRequest,
    ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];
    public string? CacheGroupKey => "GetContainerUnits";
    public bool ByPassCache { get; }
    public TimeSpan? SlidingExpiration { get; }
    public string CacheKey => $"GetListContainerUnitQuery({PageRequest.PageIndex},{PageRequest.PageSize})";


    public PageRequest PageRequest { get; set; }


    public class GetListContainerUnitQueryHandler : IRequestHandler<GetListContainerUnitQuery, GetListResponse<GetListContainerUnitListItemDto>>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public GetListContainerUnitQueryHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, ContainerUnitBusinessRules containerUnitBusinessRules)
        {
            _containerUnitRepository = containerUnitRepository;
            _mapper = mapper;
            _containerUnitBusinessRules = containerUnitBusinessRules;
        }

        public async Task<GetListResponse<GetListContainerUnitListItemDto>> Handle(GetListContainerUnitQuery request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ContainerUnit> containerUnitList = await _containerUnitRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(x => x.DepositorCompany),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListContainerUnitListItemDto>>(containerUnitList);
        }
    }

}
