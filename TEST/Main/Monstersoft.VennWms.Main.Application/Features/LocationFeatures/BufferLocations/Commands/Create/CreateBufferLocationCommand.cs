using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants.BufferLocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Create;

public class CreateBufferLocationCommand : IRequest<CreatedBufferLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBufferLocations"];

    public CreateBufferLocationDto BufferLocation { get; set; }
    public BufferLocationsDetailLevel DetailLevel { get; set; }

    public class CreateBufferLocationCommandHandler : IRequestHandler<CreateBufferLocationCommand, CreatedBufferLocationResponse>
    {
        private readonly IBufferLocationRepository _bufferLocationRepository;
        private readonly BufferLocationBusinessRules _bufferLocationBusinessRules;
        private readonly IMapper _mapper;

        public CreateBufferLocationCommandHandler(IBufferLocationRepository bufferLocationRepository, IMapper mapper, BufferLocationBusinessRules bufferLocationBusinessRules)
        {
            _bufferLocationRepository = bufferLocationRepository;
            _mapper = mapper;
            _bufferLocationBusinessRules = bufferLocationBusinessRules;
        }

        public async Task<CreatedBufferLocationResponse> Handle(CreateBufferLocationCommand request, CancellationToken cancellationToken)
        {
            _bufferLocationBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            BufferLocation bufferLocation = _mapper.Map<BufferLocation>(request.BufferLocation);
            bufferLocation.Id = Guid.NewGuid();
            bufferLocation.CreatedDate = DateTime.Now;

            await _bufferLocationRepository.AddAsync(bufferLocation);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _bufferLocationRepository.GetAsync(predicate: x => x.Id == bufferLocation.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBufferLocationResponse>(response);
            }
            else
            {
                var response = await _bufferLocationRepository.GetAsync(predicate: x => x.Id == bufferLocation.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBufferLocationResponse>(response);
            }
        }
    }
}
