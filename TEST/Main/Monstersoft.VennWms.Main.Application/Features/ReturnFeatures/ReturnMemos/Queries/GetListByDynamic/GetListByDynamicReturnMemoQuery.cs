using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants.ReturnMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetListByDynamic;

public class GetListByDynamicReturnMemoQuery : IRequest<GetListResponse<GetListByDynamicReturnMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnMemoQueryHandler : IRequestHandler<GetListByDynamicReturnMemoQuery, GetListResponse<GetListByDynamicReturnMemoListItemDto>>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnMemoQueryHandler(IReturnMemoRepository returnMemoRepository, IMapper mapper, ReturnMemoBusinessRules returnMemoBusinessRules)
        {
            _returnMemoRepository = returnMemoRepository;
            _returnMemoBusinessRules = returnMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnMemoListItemDto>> Handle(GetListByDynamicReturnMemoQuery request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnMemo> returnMemoList = await _returnMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnMemoListItemDto>>(returnMemoList);
        }
    }

}
