using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
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
    public PoTypeDetailLevel DetailLevel { get; set; }

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

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodePoTypeResponse>(await _poTypeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<PoType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrders);
                    }

                    var includableQuery = query as IIncludableQueryable<PoType, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodePoTypeResponse>(await _poTypeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
