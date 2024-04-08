using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicReturnItmStockAttrValueQuery : IRequest<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnItmStockAttrValueQueryHandler : IRequestHandler<GetListByDynamicReturnItmStockAttrValueQuery, GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnItmStockAttrValueQueryHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>> Handle(GetListByDynamicReturnItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnItmStockAttrValue> returnItmStockAttrValueList = await _returnItmStockAttrValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>(returnItmStockAttrValueList);
        }
    }

}

