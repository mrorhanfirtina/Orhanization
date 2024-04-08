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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetById;

public class GetByIdStorageSystemQuery : IRequest<GetByIdStorageSystemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdStorageSystemQueryHandler : IRequestHandler<GetByIdStorageSystemQuery, GetByIdStorageSystemResponse>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStorageSystemQueryHandler(IStorageSystemRepository storageSystemRepository, IMapper mapper, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _mapper = mapper;
            _storageSystemBusinessRules = storageSystemBusinessRules;
        }

        public async Task<GetByIdStorageSystemResponse> Handle(GetByIdStorageSystemQuery request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdStorageSystemResponse>(await _storageSystemRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

