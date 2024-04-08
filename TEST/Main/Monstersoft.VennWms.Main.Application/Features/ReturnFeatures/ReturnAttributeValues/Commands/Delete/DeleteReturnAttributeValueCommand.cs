using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Delete;

public class DeleteReturnAttributeValueCommand : IRequest<DeletedReturnAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReturnAttributeValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributeValues";

    public Guid Id { get; set; }


    public class DeleteReturnAttributeValueCommandHandler : IRequestHandler<DeleteReturnAttributeValueCommand, DeletedReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;

        public DeleteReturnAttributeValueCommandHandler(IReturnAttributeValueRepository returnAttributeValueRepository, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
        }

        public async Task<DeletedReturnAttributeValueResponse> Handle(DeleteReturnAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReturnAttributeValue returnAttributeValue = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _returnAttributeValueRepository.DeleteAsync(returnAttributeValue);

            return new DeletedReturnAttributeValueResponse
            {
                Id = returnAttributeValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReturnAttributeValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}

