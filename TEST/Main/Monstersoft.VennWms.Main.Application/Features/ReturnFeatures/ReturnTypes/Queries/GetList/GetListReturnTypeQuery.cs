using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants.ReturnTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetList;

public class GetListReturnTypeQuery : IRequest<GetListResponse<GetListReturnTypeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListReturnTypeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetReturnTypes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListReturnTypeQueryHandler : IRequestHandler<GetListReturnTypeQuery, GetListResponse<GetListReturnTypeListItemDto>>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListReturnTypeQueryHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _mapper = mapper;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<GetListResponse<GetListReturnTypeListItemDto>> Handle(GetListReturnTypeQuery request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnType> returnTypeList = await _returnTypeRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Returns),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListReturnTypeListItemDto>>(returnTypeList);
        }
    }

}
