using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants.PoTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetListByDynamic;

public class GetListByDynamicPoTypeQuery : IRequest<GetListResponse<GetListByDynamicPoTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicPoTypeQueryHandler : IRequestHandler<GetListByDynamicPoTypeQuery, GetListResponse<GetListByDynamicPoTypeListItemDto>>
    {
        private readonly IPoTypeRepository _poTypeRepository;
        private readonly PoTypeBusinessRules _poTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicPoTypeQueryHandler(IPoTypeRepository poTypeRepository, IMapper mapper, PoTypeBusinessRules poTypeBusinessRules)
        {
            _poTypeRepository = poTypeRepository;
            _poTypeBusinessRules = poTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicPoTypeListItemDto>> Handle(GetListByDynamicPoTypeQuery request, CancellationToken cancellationToken)
        {
            _poTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<PoType> poTypeList = await _poTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.PurchaseOrders),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicPoTypeListItemDto>>(poTypeList);
        }
    }

}
