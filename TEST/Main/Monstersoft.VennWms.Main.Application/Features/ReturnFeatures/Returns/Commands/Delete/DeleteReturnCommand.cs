using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Delete;

public class DeleteReturnCommand : IRequest<DeletedReturnResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturns";

    public Guid Id { get; set; }


    public class DeleteReturnCommandHandler : IRequestHandler<DeleteReturnCommand, DeletedReturnResponse>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;

        public DeleteReturnCommandHandler(IReturnRepository returnRepository, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<DeletedReturnResponse> Handle(DeleteReturnCommand request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Return returnEntity = await _returnRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _returnRepository.DeleteAsync(returnEntity);

            return new DeletedReturnResponse
            {
                Id = returnEntity.Id,
                DepositorCompanyId = depositorCompanyId, DepositorId = returnEntity.DepositorId,
                IsSuccess = true,
                Message = ReturnMessages.RequestExecutedSuccessfully
            };
        }
    }
}
