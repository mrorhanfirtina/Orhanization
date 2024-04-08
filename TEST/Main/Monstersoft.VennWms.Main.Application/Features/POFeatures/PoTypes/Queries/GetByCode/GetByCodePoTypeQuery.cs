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


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetByCode;

public class GetByCodePoTypeQuery : IRequest<GetByCodePoTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodePoTypeQueryHandler : IRequestHandler<GetByCodePoTypeQuery, GetByCodePoTypeResponse>
    {
        private readonly IPoTypeRepository _poTypeRepository;
        private readonly PoTypeBusinessRules _poTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodePoTypeQueryHandler(IPoTypeRepository poTypeRepository, IMapper mapper, PoTypeBusinessRules poTypeBusinessRules)
        {
            _poTypeRepository = poTypeRepository;
            _mapper = mapper;
            _poTypeBusinessRules = poTypeBusinessRules;
        }

        public async Task<GetByCodePoTypeResponse> Handle(GetByCodePoTypeQuery request, CancellationToken cancellationToken)
        {
            _poTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodePoTypeResponse>(await _poTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.PurchaseOrders),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
