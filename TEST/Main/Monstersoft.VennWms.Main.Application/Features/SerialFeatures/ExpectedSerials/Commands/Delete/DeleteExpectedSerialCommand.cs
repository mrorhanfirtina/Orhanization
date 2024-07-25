using MediatR;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants.ExpectedSerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Delete;

public class DeleteExpectedSerialCommand : IRequest<DeletedExpectedSerialResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ExpectedSerialOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerials"];

    public Guid Id { get; set; }


    public class DeleteExpectedSerialCommandHandler : IRequestHandler<DeleteExpectedSerialCommand, DeletedExpectedSerialResponse>
    {
        private readonly IExpectedSerialRepository _expectedSerialRepository;
        private readonly ExpectedSerialBusinessRules _expectedSerialBusinessRules;

        public DeleteExpectedSerialCommandHandler(IExpectedSerialRepository expectedSerialRepository, ExpectedSerialBusinessRules expectedSerialBusinessRules)
        {
            _expectedSerialRepository = expectedSerialRepository;
            _expectedSerialBusinessRules = expectedSerialBusinessRules;
        }

        public async Task<DeletedExpectedSerialResponse> Handle(DeleteExpectedSerialCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ExpectedSerial expectedSerial = await _expectedSerialRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _expectedSerialRepository.DeleteAsync(expectedSerial);

            return new DeletedExpectedSerialResponse
            {
                Id = expectedSerial.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
