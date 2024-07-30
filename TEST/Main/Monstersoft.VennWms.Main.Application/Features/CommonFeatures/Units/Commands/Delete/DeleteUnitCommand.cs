
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Delete;

public class DeleteUnitCommand : IRequest<DeletedUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnits"];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [ Admin, User, Write, UnitOperationClaims.Delete];

    public int Id { get; set; }


    public class DeleteUnitCommandHandler : IRequestHandler<DeleteUnitCommand, DeletedUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;

        public DeleteUnitCommandHandler(IUnitRepository unitRepository, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _unitBusinessRules = unitBusinessRules;
        }

        public async Task<DeletedUnitResponse> Handle(DeleteUnitCommand request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Unit unit = await _unitRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.ReferenceUnitConversions),
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _unitRepository.DeleteAsync(unit);

            return new DeletedUnitResponse
            {
                Id = unit.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = UnitMessages.RequestExecutedSuccessfully
            };
        }
    }

}
