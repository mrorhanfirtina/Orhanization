using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants.PoTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetById;

public class GetByIdPoTypeQuery : IRequest<GetByIdPoTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdPoTypeQueryHandler : IRequestHandler<GetByIdPoTypeQuery, GetByIdPoTypeResponse>
    {
        private readonly IPoTypeRepository _poTypeRepository;
        private readonly PoTypeBusinessRules _poTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPoTypeQueryHandler(IPoTypeRepository poTypeRepository, IMapper mapper, PoTypeBusinessRules poTypeBusinessRules)
        {
            _poTypeRepository = poTypeRepository;
            _mapper = mapper;
            _poTypeBusinessRules = poTypeBusinessRules;
        }

        public async Task<GetByIdPoTypeResponse> Handle(GetByIdPoTypeQuery request, CancellationToken cancellationToken)
        {
            _poTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdPoTypeResponse>(await _poTypeRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.PurchaseOrders),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
