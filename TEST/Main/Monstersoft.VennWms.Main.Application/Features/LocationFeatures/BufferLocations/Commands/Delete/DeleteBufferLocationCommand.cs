using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants.BufferLocationOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Delete;

public class DeleteBufferLocationCommand : IRequest<DeletedBufferLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, BufferLocationOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBufferLocations"];

    public Guid Id { get; set; }


    public class DeleteBufferLocationCommandHandler : IRequestHandler<DeleteBufferLocationCommand, DeletedBufferLocationResponse>
    {
        private readonly IBufferLocationRepository _bufferLocationRepository;
        private readonly BufferLocationBusinessRules _bufferLocationBusinessRules;

        public DeleteBufferLocationCommandHandler(IBufferLocationRepository bufferLocationRepository, BufferLocationBusinessRules bufferLocationBusinessRules)
        {
            _bufferLocationRepository = bufferLocationRepository;
            _bufferLocationBusinessRules = bufferLocationBusinessRules;
        }

        public async Task<DeletedBufferLocationResponse> Handle(DeleteBufferLocationCommand request, CancellationToken cancellationToken)
        {
            _bufferLocationBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            BufferLocation bufferLocation = await _bufferLocationRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _bufferLocationRepository.DeleteAsync(bufferLocation);

            return new DeletedBufferLocationResponse
            {
                Id = bufferLocation.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
