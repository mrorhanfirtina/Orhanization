using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Update;

public class UpdateBufferLocationCommand : IRequest<UpdatedBufferLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, BufferLocationOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBufferLocations"];

    public UpdateBufferLocationDto BufferLocation { get; set; }
    public BufferLocationsDetailLevel DetailLevel { get; set; }



    public class UpdateBufferLocationCommandHandler : IRequestHandler<UpdateBufferLocationCommand, UpdatedBufferLocationResponse>
    {
        private readonly IBufferLocationRepository _bufferLocationRepository;
        private readonly BufferLocationBusinessRules _bufferLocationBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBufferLocationCommandHandler(IBufferLocationRepository bufferLocationRepository, BufferLocationBusinessRules bufferLocationBusinessRules, IMapper mapper)
        {
            _bufferLocationRepository = bufferLocationRepository;
            _bufferLocationBusinessRules = bufferLocationBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedBufferLocationResponse> Handle(UpdateBufferLocationCommand request, CancellationToken cancellationToken)
        {
            _bufferLocationBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.BufferLocation.Id);


            BufferLocation? currentBufferLocation = await _bufferLocationRepository.GetAsync(predicate: x => x.Id == request.BufferLocation.Id);

            BufferLocation? bufferLocation = _mapper.Map(request.BufferLocation, currentBufferLocation);
            bufferLocation.UpdatedDate = DateTime.Now;

            await _bufferLocationRepository.UpdateAsync(bufferLocation);

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

                return _mapper.Map<UpdatedBufferLocationResponse>(response);
            }
            else
            {
                var response = await _bufferLocationRepository.GetAsync(predicate: x => x.Id == bufferLocation.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBufferLocationResponse>(response);
            }
        }
    }
}
