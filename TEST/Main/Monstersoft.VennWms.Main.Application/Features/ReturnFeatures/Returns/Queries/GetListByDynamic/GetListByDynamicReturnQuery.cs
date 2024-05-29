using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetListByDynamic;

public class GetListByDynamicReturnQuery : IRequest<GetListResponse<GetListByDynamicReturnListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnQueryHandler : IRequestHandler<GetListByDynamicReturnQuery, GetListResponse<GetListByDynamicReturnListItemDto>>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _returnBusinessRules = returnBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnListItemDto>> Handle(GetListByDynamicReturnQuery request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Return> returnList = await _returnRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
             include: x => x.Include(y => y.ReturnAttributeValues)
                            .Include(y => y.ReturnMemos)
                            .Include(y => y.ReturnItems)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItemMemos)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItmStockAttrValues),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnListItemDto>>(returnList);
        }
    }

}
