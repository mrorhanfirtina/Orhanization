using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Rules;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants.CompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Delete;

public class DeleteCompanyCommand : IRequest<DeletedCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Write, CompanyOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetCompanies";

    public Guid Id { get; set; }


    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, DeletedCompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyBusinessRules _companyBusinessRules;
        private readonly IAddressRepository _addressRepository;

        public DeleteCompanyCommandHandler(ICompanyRepository companyRepository, CompanyBusinessRules companyBusinessRules, IAddressRepository addressRepository)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _addressRepository = addressRepository;
        }

        public async Task<DeletedCompanyResponse> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Company company = await _companyRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _companyRepository.DeleteAsync(company);
            await _addressRepository.DeleteAsync(company.Address);

            return new DeletedCompanyResponse
            {
                Id = company.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = CompanyMessages.RequestExecutedSuccessfully
            };
        }
    }
}
