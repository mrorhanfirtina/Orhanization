using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants.UnitConversionOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetById;

public class GetByIdUnitConversionQuery : IRequest<GetByIdUnitConversionResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public int Id { get; set; }
    public UnitConversionDetailLevel DetailLevel { get; set; }

    public class GetByIdUnitConversionQueryHandler : IRequestHandler<GetByIdUnitConversionQuery, GetByIdUnitConversionResponse>
    {
        private readonly IUnitConversionRepository _unitConversionRepository;
        private readonly UnitConversionBusinessRules _unitConversionBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdUnitConversionQueryHandler(IUnitConversionRepository unitConversionRepository, IMapper mapper, UnitConversionBusinessRules unitConversionBusinessRules)
        {
            _unitConversionRepository = unitConversionRepository;
            _mapper = mapper;
            _unitConversionBusinessRules = unitConversionBusinessRules;
        }

        public async Task<GetByIdUnitConversionResponse> Handle(GetByIdUnitConversionQuery request, CancellationToken cancellationToken)
        {
            _unitConversionBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdUnitConversionResponse>(await _unitConversionRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<UnitConversion> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReferenceUnit)
                    {
                        query = query.Include(y => y.ReferenceUnit);
                    }

                    if (detailLevel.IncludeTargetUnit)
                    {
                        query = query.Include(y => y.TargetUnit);
                    }

                    var includableQuery = query as IIncludableQueryable<UnitConversion, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdUnitConversionResponse>(await _unitConversionRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
