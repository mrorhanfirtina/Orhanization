using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetListByDynamic;

public class GetListByDynamicStorageSystemQuery : IRequest<GetListResponse<GetListByDynamicStorageSystemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicStorageSystemQueryHandler : IRequestHandler<GetListByDynamicStorageSystemQuery, GetListResponse<GetListByDynamicStorageSystemListItemDto>>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicStorageSystemQueryHandler(IStorageSystemRepository storageSystemRepository, IMapper mapper, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _storageSystemBusinessRules = storageSystemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicStorageSystemListItemDto>> Handle(GetListByDynamicStorageSystemQuery request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StorageSystem> storageSystemList = await _storageSystemRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicStorageSystemListItemDto>>(storageSystemList);
        }
    }

}

