using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants.ReturnMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Delete;

public class DeleteReturnMemoCommand : IRequest<DeletedReturnMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnMemos"];

    public Guid Id { get; set; }


    public class DeleteReturnMemoCommandHandler : IRequestHandler<DeleteReturnMemoCommand, DeletedReturnMemoResponse>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;

        public DeleteReturnMemoCommandHandler(IReturnMemoRepository returnMemoRepository, ReturnMemoBusinessRules returnMemoBusinessRules)
        {
            _returnMemoRepository = returnMemoRepository;
            _returnMemoBusinessRules = returnMemoBusinessRules;
        }

        public async Task<DeletedReturnMemoResponse> Handle(DeleteReturnMemoCommand request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnMemo returnMemo = await _returnMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnMemoRepository.DeleteAsync(returnMemo);

            return new DeletedReturnMemoResponse
            {
                Id = returnMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}
