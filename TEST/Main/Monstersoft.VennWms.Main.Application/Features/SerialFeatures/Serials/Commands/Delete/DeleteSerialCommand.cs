using MediatR;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants.SerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Delete;

public class DeleteSerialCommand : IRequest<DeletedSerialResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, SerialOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerials"];

    public Guid Id { get; set; }


    public class DeleteSerialCommandHandler : IRequestHandler<DeleteSerialCommand, DeletedSerialResponse>
    {
        private readonly ISerialRepository _serialRepository;
        private readonly SerialBusinessRules _serialBusinessRules;

        public DeleteSerialCommandHandler(ISerialRepository serialRepository, SerialBusinessRules serialBusinessRules)
        {
            _serialRepository = serialRepository;
            _serialBusinessRules = serialBusinessRules;
        }

        public async Task<DeletedSerialResponse> Handle(DeleteSerialCommand request, CancellationToken cancellationToken)
        {
            _serialBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Serial serial = await _serialRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _serialRepository.DeleteAsync(serial);

            return new DeletedSerialResponse
            {
                Id = serial.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
