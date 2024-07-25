using MediatR;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants.PoAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Delete;

public class DeletePoAttributeCommand : IRequest<DeletedPoAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, PoAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetPoAttributes"];

    public Guid Id { get; set; }


    public class DeletePoAttributeCommandHandler : IRequestHandler<DeletePoAttributeCommand, DeletedPoAttributeResponse>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;

        public DeletePoAttributeCommandHandler(IPoAttributeRepository poAttributeRepository, PoAttributeBusinessRules poAttributeBusinessRules)
        {
            _poAttributeRepository = poAttributeRepository;
            _poAttributeBusinessRules = poAttributeBusinessRules;
        }

        public async Task<DeletedPoAttributeResponse> Handle(DeletePoAttributeCommand request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            PoAttribute poAttribute = await _poAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _poAttributeRepository.DeleteAsync(poAttribute);

            return new DeletedPoAttributeResponse
            {
                Id = poAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = PoAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

