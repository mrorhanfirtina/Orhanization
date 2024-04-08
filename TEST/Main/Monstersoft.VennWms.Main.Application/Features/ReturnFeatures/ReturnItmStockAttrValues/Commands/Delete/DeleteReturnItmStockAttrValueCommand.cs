using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Delete;

public class DeleteReturnItmStockAttrValueCommand : IRequest<DeletedReturnItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnItemStockAttrValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItmStockAttrValues";

    public Guid Id { get; set; }


    public class DeleteReturnItmStockAttrValueCommandHandler : IRequestHandler<DeleteReturnItmStockAttrValueCommand, DeletedReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;

        public DeleteReturnItmStockAttrValueCommandHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
        }

        public async Task<DeletedReturnItmStockAttrValueResponse> Handle(DeleteReturnItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnItmStockAttrValue returnItmStockAttrValue = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnItmStockAttrValueRepository.DeleteAsync(returnItmStockAttrValue);

            return new DeletedReturnItmStockAttrValueResponse
            {
                Id = returnItmStockAttrValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnItmStockAttrValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}

