using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;


namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetListByDynamic;

public class GetListByDynamicUnitQuery : IRequest<GetListResponse<GetListByDynamicUnitListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public UnitDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicUnitQueryHandler : IRequestHandler<GetListByDynamicUnitQuery, GetListResponse<GetListByDynamicUnitListItemDto>>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicUnitQueryHandler(IUnitRepository unitRepository, IMapper mapper, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _unitBusinessRules = unitBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicUnitListItemDto>> Handle(GetListByDynamicUnitQuery request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Unit> unitList = await _unitRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
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
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicUnitListItemDto>>(unitList);
            }
            else
            {
                Paginate<Unit> unitList = await _unitRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicUnitListItemDto>>(unitList);
            }
        }
    }

}
