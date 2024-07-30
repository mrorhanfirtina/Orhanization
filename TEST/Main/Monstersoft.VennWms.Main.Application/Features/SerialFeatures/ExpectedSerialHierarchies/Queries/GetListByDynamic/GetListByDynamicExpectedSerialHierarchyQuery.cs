using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetListByDynamic;

public class GetListByDynamicExpectedSerialHierarchyQuery : IRequest<GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>>, ITransactionalRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    //public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ExpectedSerialHierarchiesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicExpectedSerialHierarchyQueryHandler : IRequestHandler<GetListByDynamicExpectedSerialHierarchyQuery, GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>>
    {
        private readonly IExpectedSerialHierarchyRepository _expectedSerialHierarchyRepository;
        private readonly ExpectedSerialHierarchyBusinessRules _expectedSerialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicExpectedSerialHierarchyQueryHandler(IExpectedSerialHierarchyRepository expectedSerialHierarchyRepository, IMapper mapper, ExpectedSerialHierarchyBusinessRules expectedSerialHierarchyBusinessRules)
        {
            _expectedSerialHierarchyRepository = expectedSerialHierarchyRepository;
            _expectedSerialHierarchyBusinessRules = expectedSerialHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>> Handle(GetListByDynamicExpectedSerialHierarchyQuery request, CancellationToken cancellationToken)
        {
            _expectedSerialHierarchyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<ExpectedSerialHierarchy> expectedSerialHierarchyList = await _expectedSerialHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ExpectedSerialHierarchy> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeRootSerial)
                    {
                        query = query.Include(x => x.RootSerial);
                    }

                    if (detailLevel.IncludeChildSerial)
                    {
                        query = query.Include(x => x.ChildSerial);
                    }

                    var includableQuery = query as IIncludableQueryable<ExpectedSerialHierarchy, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>>(expectedSerialHierarchyList);
            }
            else
            {
                Paginate<ExpectedSerialHierarchy> expectedSerialHierarchyList = await _expectedSerialHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicExpectedSerialHierarchyListItemDto>>(expectedSerialHierarchyList);
            }
        }
    }
}
