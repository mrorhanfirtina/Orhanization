﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetListByDynamic;

public class GetListByDynamicUnsuitReasonQuery : IRequest<GetListResponse<GetListByDynamicUnsuitReasonListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [ Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicUnsuitReasonQueryHandler : IRequestHandler<GetListByDynamicUnsuitReasonQuery, GetListResponse<GetListByDynamicUnsuitReasonListItemDto>>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicUnsuitReasonQueryHandler(IUnsuitReasonRepository unsuitReasonRepository, IMapper mapper, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicUnsuitReasonListItemDto>> Handle(GetListByDynamicUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<UnsuitReason> unsuitReasonList = await _unsuitReasonRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicUnsuitReasonListItemDto>>(unsuitReasonList);
        }
    }

}