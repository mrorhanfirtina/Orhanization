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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants.BufferLocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetById;

public class GetByIdBufferLocationQuery : IRequest<GetByIdBufferLocationResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public BufferLocationsDetailLevel DetailLevel { get; set; }



    public class GetByIdBufferLocationQueryHandler : IRequestHandler<GetByIdBufferLocationQuery, GetByIdBufferLocationResponse>
    {
        private readonly IBufferLocationRepository _bufferLocationRepository;
        private readonly BufferLocationBusinessRules _bufferLocationBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBufferLocationQueryHandler(IBufferLocationRepository bufferLocationRepository, IMapper mapper, BufferLocationBusinessRules bufferLocationBusinessRules)
        {
            _bufferLocationRepository = bufferLocationRepository;
            _mapper = mapper;
            _bufferLocationBusinessRules = bufferLocationBusinessRules;
        }

        public async Task<GetByIdBufferLocationResponse> Handle(GetByIdBufferLocationQuery request, CancellationToken cancellationToken)
        {
            _bufferLocationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdBufferLocationResponse>(await _bufferLocationRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBufferLocationResponse>(await _bufferLocationRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
