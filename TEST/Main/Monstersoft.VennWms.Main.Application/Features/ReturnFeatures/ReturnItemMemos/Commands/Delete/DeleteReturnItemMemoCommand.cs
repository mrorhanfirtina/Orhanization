using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants.ReturnItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Delete;

public class DeleteReturnItemMemoCommand : IRequest<DeletedReturnItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnItemMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItemMemos"];

    public Guid Id { get; set; }


    public class DeleteReturnItemMemoCommandHandler : IRequestHandler<DeleteReturnItemMemoCommand, DeletedReturnItemMemoResponse>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;

        public DeleteReturnItemMemoCommandHandler(IReturnItemMemoRepository returnItemMemoRepository, ReturnItemMemoBusinessRules returnItemMemoBusinessRules)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
        }

        public async Task<DeletedReturnItemMemoResponse> Handle(DeleteReturnItemMemoCommand request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnItemMemo returnItemMemo = await _returnItemMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnItemMemoRepository.DeleteAsync(returnItemMemo);

            return new DeletedReturnItemMemoResponse
            {
                Id = returnItemMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnItemMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}

