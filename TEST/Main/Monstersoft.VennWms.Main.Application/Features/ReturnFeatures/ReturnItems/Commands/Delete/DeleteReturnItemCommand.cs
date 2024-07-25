using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Delete;

public class DeleteReturnItemCommand : IRequest<DeletedReturnItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnItemOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnItems"];

    public Guid Id { get; set; }


    public class DeleteReturnItemCommandHandler : IRequestHandler<DeleteReturnItemCommand, DeletedReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;

        public DeleteReturnItemCommandHandler(IReturnItemRepository returnItemRepository, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<DeletedReturnItemResponse> Handle(DeleteReturnItemCommand request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnItem returnItem = await _returnItemRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.ReturnItemMemos)
            .Include(y => y.ReturnItmStockAttrValues),
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnItemRepository.DeleteAsync(returnItem);

            return new DeletedReturnItemResponse
            {
                Id = returnItem.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnItemMessages.RequestExecutedSuccessfully
            };
        }
    }
}
