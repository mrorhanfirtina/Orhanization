using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;

public class GetByIdUnitQuery : IRequest<GetByIdUnitResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }
    public UnitsDetailLevel DetailLevel { get; set; }


    public class GetByIdUnitQueryHandler : IRequestHandler<GetByIdUnitQuery, GetByIdUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdUnitQueryHandler(IUnitRepository unitRepository, IMapper mapper, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _unitBusinessRules = unitBusinessRules;
        }

        public async Task<GetByIdUnitResponse> Handle(GetByIdUnitQuery request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdUnitResponse>(await _unitRepository.GetAsync(x => x.Id == request.Id,
                    include: x =>
                    {
                        IQueryable<Unit> query = x;

                        var detailLevel = request.DetailLevel;

                        if (detailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.DepositorCompany);
                        }

                        if (detailLevel.IncludeReferenceUnit)
                        {
                            query = query.Include(y => y.ReferenceUnitConversions);

                            if (detailLevel.ReferenceUnitDetailLevel.IncludeTargetUnit)
                            {
                                query = query.Include(y => y.ReferenceUnitConversions).ThenInclude(z => z.TargetUnit);
                            }
                        }

                        var includableQuery = query as IIncludableQueryable<Unit, object>;
                        return includableQuery;
                    },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdUnitResponse>(await _unitRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }

            
        }
    }

}
