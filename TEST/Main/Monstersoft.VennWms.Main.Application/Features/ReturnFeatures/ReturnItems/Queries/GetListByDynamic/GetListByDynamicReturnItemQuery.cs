using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetListByDynamic;

public class GetListByDynamicReturnItemQuery : IRequest<GetListResponse<GetListByDynamicReturnItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnItemQueryHandler : IRequestHandler<GetListByDynamicReturnItemQuery, GetListResponse<GetListByDynamicReturnItemListItemDto>>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnItemQueryHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _returnItemBusinessRules = returnItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnItemListItemDto>> Handle(GetListByDynamicReturnItemQuery request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnItem> returnItemList = await _returnItemRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            include: m => m.Include(x => x.ReturnItemMemos).Include(x => x.ReturnItmStockAttrValues),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnItemListItemDto>>(returnItemList);
        }
    }

}
