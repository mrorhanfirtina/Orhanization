﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants.ReturnItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetListByDynamic;

public class GetListByDynamicReturnItemMemoQuery : IRequest<GetListResponse<GetListByDynamicReturnItemMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnItemMemoQueryHandler : IRequestHandler<GetListByDynamicReturnItemMemoQuery, GetListResponse<GetListByDynamicReturnItemMemoListItemDto>>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnItemMemoQueryHandler(IReturnItemMemoRepository returnItemMemoRepository, IMapper mapper, ReturnItemMemoBusinessRules returnItemMemoBusinessRules)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnItemMemoListItemDto>> Handle(GetListByDynamicReturnItemMemoQuery request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnItemMemo> returnItemMemoList = await _returnItemMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnItemMemoListItemDto>>(returnItemMemoList);
        }
    }


}

