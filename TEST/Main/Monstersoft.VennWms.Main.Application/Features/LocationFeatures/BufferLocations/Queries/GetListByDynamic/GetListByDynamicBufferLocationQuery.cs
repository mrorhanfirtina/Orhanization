using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants.BufferLocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetListByDynamic;

public class GetListByDynamicBufferLocationQuery : IRequest<GetListResponse<GetListByDynamicBufferLocationListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public BufferLocationsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicBufferLocationQueryHandler : IRequestHandler<GetListByDynamicBufferLocationQuery, GetListResponse<GetListByDynamicBufferLocationListItemDto>>
    {
        private readonly IBufferLocationRepository _bufferLocationRepository;
        private readonly BufferLocationBusinessRules _bufferLocationBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBufferLocationQueryHandler(IBufferLocationRepository bufferLocationRepository, IMapper mapper, BufferLocationBusinessRules bufferLocationBusinessRules)
        {
            _bufferLocationRepository = bufferLocationRepository;
            _bufferLocationBusinessRules = bufferLocationBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBufferLocationListItemDto>> Handle(GetListByDynamicBufferLocationQuery request, CancellationToken cancellationToken)
        {
            _bufferLocationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<BufferLocation> bufferLocationList = await _bufferLocationRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<BufferLocation> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(x => x.Location);
                    }

                    if (detailLevel.IncludeBuffLocation)
                    {
                        query = query.Include(x => x.BuffLocation);
                    }

                    var includableQuery = query as IIncludableQueryable<BufferLocation, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBufferLocationListItemDto>>(bufferLocationList);
            }
            else
            {
                Paginate<BufferLocation> bufferLocationList = await _bufferLocationRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBufferLocationListItemDto>>(bufferLocationList);
            }
        }
    }
}
