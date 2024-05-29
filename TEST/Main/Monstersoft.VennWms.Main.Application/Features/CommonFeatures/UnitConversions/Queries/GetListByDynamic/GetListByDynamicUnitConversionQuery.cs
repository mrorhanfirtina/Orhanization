using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants.UnitConversionOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Queries.GetListByDynamic;

public class GetListByDynamicUnitConversionQuery : IRequest<GetListResponse<GetListByDynamicUnitConversionListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public UnitConversionDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicUnitConversionQueryHandler : IRequestHandler<GetListByDynamicUnitConversionQuery, GetListResponse<GetListByDynamicUnitConversionListItemDto>>
    {
        private readonly IUnitConversionRepository _unitConversionRepository;
        private readonly UnitConversionBusinessRules _unitConversionBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicUnitConversionQueryHandler(IUnitConversionRepository unitConversionRepository, IMapper mapper, UnitConversionBusinessRules unitConversionBusinessRules)
        {
            _unitConversionRepository = unitConversionRepository;
            _unitConversionBusinessRules = unitConversionBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicUnitConversionListItemDto>> Handle(GetListByDynamicUnitConversionQuery request, CancellationToken cancellationToken)
        {
            _unitConversionBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<UnitConversion> unitConversionList = await _unitConversionRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicUnitConversionListItemDto>>(unitConversionList);
            }
            else
            {
                Paginate<UnitConversion> unitConversionList = await _unitConversionRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicUnitConversionListItemDto>>(unitConversionList);
            }

            
        }
    }
}
