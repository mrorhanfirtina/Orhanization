using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants.ReserveReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Delete;

public class DeleteReserveReasonCommand : IRequest<DeletedReserveReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReserveReasons";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, ReserveReasonOperationClaims.Delete];

    public Guid Id { get; set; }


    public class DeleteReserveReasonCommandHandler : IRequestHandler<DeleteReserveReasonCommand, DeletedReserveReasonResponse>
    {
        private readonly IReserveReasonRepository _reserveReasonRepository;
        private readonly ReserveReasonBusinessRules _reserveReasonBusinessRules;

        public DeleteReserveReasonCommandHandler(IReserveReasonRepository reserveReasonRepository, ReserveReasonBusinessRules reserveReasonBusinessRules)
        {
            _reserveReasonRepository = reserveReasonRepository;
            _reserveReasonBusinessRules = reserveReasonBusinessRules;
        }

        public async Task<DeletedReserveReasonResponse> Handle(DeleteReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _reserveReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReserveReason reserveReason = await _reserveReasonRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _reserveReasonRepository.DeleteAsync(reserveReason);

            return new DeletedReserveReasonResponse
            {
                Id = reserveReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReserveReasonMessages.RequestExecutedSuccessfully
            };
        }
    }

}
