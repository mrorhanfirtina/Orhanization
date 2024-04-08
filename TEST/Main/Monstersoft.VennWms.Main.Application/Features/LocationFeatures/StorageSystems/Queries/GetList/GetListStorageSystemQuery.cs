using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetList;

public class GetListStorageSystemQuery : IRequest<GetListResponse<GetListStorageSystemListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListStorageSystemQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetStorageSystems";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListStorageSystemQueryHandler : IRequestHandler<GetListStorageSystemQuery, GetListResponse<GetListStorageSystemListItemDto>>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public GetListStorageSystemQueryHandler(IStorageSystemRepository storageSystemRepository, IMapper mapper, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _mapper = mapper;
            _storageSystemBusinessRules = storageSystemBusinessRules;
        }

        public async Task<GetListResponse<GetListStorageSystemListItemDto>> Handle(GetListStorageSystemQuery request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StorageSystem> storageSystemList = await _storageSystemRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListStorageSystemListItemDto>>(storageSystemList);
        }
    }

}

