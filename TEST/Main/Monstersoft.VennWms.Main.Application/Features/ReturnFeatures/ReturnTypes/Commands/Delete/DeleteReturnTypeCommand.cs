using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants.ReturnTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Delete;

public class DeleteReturnTypeCommand : IRequest<DeletedReturnTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnTypeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnTypes"];

    public Guid Id { get; set; }


    public class DeleteReturnTypeCommandHandler : IRequestHandler<DeleteReturnTypeCommand, DeletedReturnTypeResponse>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;

        public DeleteReturnTypeCommandHandler(IReturnTypeRepository returnTypeRepository, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<DeletedReturnTypeResponse> Handle(DeleteReturnTypeCommand request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnType returnType = await _returnTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnTypeRepository.DeleteAsync(returnType);

            return new DeletedReturnTypeResponse
            {
                Id = returnType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}
