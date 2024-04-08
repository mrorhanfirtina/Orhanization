using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetByCode;

public class GetByCodeStorageSystemQuery : IRequest<GetByCodeStorageSystemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }



    public class GetByCodeStorageSystemQueryHandler : IRequestHandler<GetByCodeStorageSystemQuery, GetByCodeStorageSystemResponse>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeStorageSystemQueryHandler(IStorageSystemRepository storageSystemRepository, IMapper mapper, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _mapper = mapper;
            _storageSystemBusinessRules = storageSystemBusinessRules;
        }

        public async Task<GetByCodeStorageSystemResponse> Handle(GetByCodeStorageSystemQuery request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeStorageSystemResponse>(await _storageSystemRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

