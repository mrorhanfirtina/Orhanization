using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Delete;

public class DeleteDepositorCompanyCommand : IRequest<DeletedDepositorCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, DepositorCompanyOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositorCompanies";

    public Guid Id { get; set; }


    public class DeleteDepositorCompanyCommandHandler : IRequestHandler<DeleteDepositorCompanyCommand, DeletedDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;

        public DeleteDepositorCompanyCommandHandler(IDepositorCompanyRepository depositorCompanyRepository, DepositorCompanyBusinessRules depositorCompanyBusinessRules)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
        }

        public async Task<DeletedDepositorCompanyResponse> Handle(DeleteDepositorCompanyCommand request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            DepositorCompany? depositorCompany = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: true,
            cancellationToken: cancellationToken);

            depositorCompany.Address.DeletedDate = DateTime.Now;

            await _depositorCompanyRepository.DeleteAsync(depositorCompany);

            return new DeletedDepositorCompanyResponse
            {
                Id = depositorCompany.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = DepositorCompanyMessages.RequestExecutedSuccessfully
            };
        }
    }
}
