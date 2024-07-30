using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants.UnitConversionOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Delete;

public class DeleteUnitConversionCommand : IRequest<DeletedUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, UnitConversionOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnitConversions"];

    public int Id { get; set; }

    public class DeleteUnitConversionCommandHandler : IRequestHandler<DeleteUnitConversionCommand, DeletedUnitConversionResponse>
    {
        private readonly IUnitConversionRepository _unitConversionRepository;
        private readonly UnitConversionBusinessRules _unitConversionBusinessRules;

        public DeleteUnitConversionCommandHandler(IUnitConversionRepository unitConversionRepository, UnitConversionBusinessRules unitConversionBusinessRules)
        {
            _unitConversionRepository = unitConversionRepository;
            _unitConversionBusinessRules = unitConversionBusinessRules;
        }

        public async Task<DeletedUnitConversionResponse> Handle(DeleteUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _unitConversionBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            UnitConversion unitConversion = await _unitConversionRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _unitConversionRepository.DeleteAsync(unitConversion);

            return new DeletedUnitConversionResponse
            {
                Id = unitConversion.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = UnitConversionMessages.RequestExecutedSuccessfully
            };
        }
    }
}
