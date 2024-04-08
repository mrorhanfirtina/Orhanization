using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetById;

public class GetByIdItemPackTypeQuery : IRequest<GetByIdItemPackTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdItemPackTypeQueryHandler : IRequestHandler<GetByIdItemPackTypeQuery, GetByIdItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _ıtemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _ıtemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemPackTypeQueryHandler(IItemPackTypeRepository ıtemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules ıtemPackTypeBusinessRules)
        {
            _ıtemPackTypeRepository = ıtemPackTypeRepository;
            _mapper = mapper;
            _ıtemPackTypeBusinessRules = ıtemPackTypeBusinessRules;
        }

        public async Task<GetByIdItemPackTypeResponse> Handle(GetByIdItemPackTypeQuery request, CancellationToken cancellationToken)
        {
            _ıtemPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdItemPackTypeResponse>(await _ıtemPackTypeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
