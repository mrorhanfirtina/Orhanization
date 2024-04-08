using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants.ReturnTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetListByDynamic;

public class GetListByDynamicReturnTypeQuery : IRequest<GetListResponse<GetListByDynamicReturnTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnTypeQueryHandler : IRequestHandler<GetListByDynamicReturnTypeQuery, GetListResponse<GetListByDynamicReturnTypeListItemDto>>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnTypeQueryHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _returnTypeBusinessRules = returnTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnTypeListItemDto>> Handle(GetListByDynamicReturnTypeQuery request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnType> returnTypeList = await _returnTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Returns),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnTypeListItemDto>>(returnTypeList);
        }
    }

}
