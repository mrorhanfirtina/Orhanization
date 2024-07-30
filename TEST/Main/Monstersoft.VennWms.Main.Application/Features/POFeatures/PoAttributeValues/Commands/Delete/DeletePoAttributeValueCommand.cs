using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Delete;

public class DeletePoAttributeValueCommand : IRequest<DeletedPoAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, PoAttributeValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetPoAttributeValues"];

    public Guid Id { get; set; }


    public class DeletePoAttributeValueCommandHandler : IRequestHandler<DeletePoAttributeValueCommand, DeletedPoAttributeValueResponse>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;

        public DeletePoAttributeValueCommandHandler(IPoAttributeValueRepository poAttributeValueRepository, PoAttributeValueBusinessRules poAttributeValueBusinessRules)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
        }

        public async Task<DeletedPoAttributeValueResponse> Handle(DeletePoAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            PoAttributeValue poAttributeValue = await _poAttributeValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _poAttributeValueRepository.DeleteAsync(poAttributeValue);

            return new DeletedPoAttributeValueResponse
            {
                Id = poAttributeValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = PoAttributeValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}

