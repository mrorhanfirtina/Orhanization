using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Rules;
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

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetListByDynamic;

public class GetListByDynamicSerialHierarchyQuery : IRequest<GetListResponse<GetListByDynamicSerialHierarchyListItemDto>>, ITransactionalRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    //public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public SerialHierarchiesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicSerialHierarchyQueryHandler : IRequestHandler<GetListByDynamicSerialHierarchyQuery, GetListResponse<GetListByDynamicSerialHierarchyListItemDto>>
    {
        private readonly ISerialHierarchyRepository _serialHierarchyRepository;
        private readonly SerialHierarchyBusinessRules _serialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSerialHierarchyQueryHandler(ISerialHierarchyRepository serialHierarchyRepository, IMapper mapper, SerialHierarchyBusinessRules serialHierarchyBusinessRules)
        {
            _serialHierarchyRepository = serialHierarchyRepository;
            _serialHierarchyBusinessRules = serialHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSerialHierarchyListItemDto>> Handle(GetListByDynamicSerialHierarchyQuery request, CancellationToken cancellationToken)
        {
            _serialHierarchyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<SerialHierarchy> serialHierarchyList = await _serialHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<SerialHierarchy> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeRootSerial)
                    {
                        query = query.Include(x => x.RootSerial);
                    }

                    if (detailLevel.IncludeChildSerial)
                    {
                        query = query.Include(x => x.ChildSerial);
                    }

                    var includableQuery = query as IIncludableQueryable<SerialHierarchy, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialHierarchyListItemDto>>(serialHierarchyList);
            }
            else
            {
                Paginate<SerialHierarchy> serialHierarchyList = await _serialHierarchyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialHierarchyListItemDto>>(serialHierarchyList);
            }
        }
    }
}
