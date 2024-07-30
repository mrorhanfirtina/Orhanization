using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Delete;

public class DeleteDistributorCommand : IRequest<DeletedDistributorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, DistributorOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetDisturbitors"];

    public Guid Id { get; set; }


    public class DeleteDisturbitorCommandHandler : IRequestHandler<DeleteDistributorCommand, DeletedDistributorResponse>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;

        public DeleteDisturbitorCommandHandler(IDistributorRepository disturbitorRepository, DistributorBusinessRules disturbitorBusinessRules)
        {
            _disturbitorRepository = disturbitorRepository;
            _disturbitorBusinessRules = disturbitorBusinessRules;
        }

        public async Task<DeletedDistributorResponse> Handle(DeleteDistributorCommand request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Distributor? disturbitor = await _disturbitorRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: true,
            cancellationToken: cancellationToken);

            disturbitor.Address.DeletedDate = DateTime.Now;

            await _disturbitorRepository.DeleteAsync(disturbitor);

            return new DeletedDistributorResponse
            {
                Id = disturbitor.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = Application.Rules.Messages.BaseMessages.RequestExecutedSuccessfully
            };
        }
    }

}

