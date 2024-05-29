using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants.CompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;

public class UpdateCompanyCommand : IRequest<UpdatedCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, CompanyOperationClaims.Update];
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetCompanies";

    public UpdateCompanyDto Company { get; set; }
    public CompanyDetailLevel DetailLevel { get; set; }


    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdatedCompanyResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly CompanyBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateCompanyCommandHandler(ICompanyRepository companyRepository, CompanyBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedCompanyResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckIdExistence(request.Company.Id)
                .CheckCodeExistenceWhenUpdate(request.Company.Code, request.Company.Id);

            Company currentCompany = await _companyRepository.GetAsync(predicate: x => x.Id == request.Company.Id && !x.DeletedDate.HasValue, 
                include: x => x.Include(y => y.Address));

            Company? company = _mapper.Map(request.Company, currentCompany);
            company.UpdatedDate = DateTime.Now;
            company.Address.UpdatedDate = DateTime.Now;

            await _companyRepository.UpdateAsync(company);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _companyRepository.GetAsync(predicate: x => x.Id == company.Id,
                include: x =>
                {
                    IQueryable<Company> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }


                    var includableQuery = query as IIncludableQueryable<Company, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedCompanyResponse>(response);
            }
            else
            {
                var response = await _companyRepository.GetAsync(predicate: x => x.Id == company.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedCompanyResponse>(response);
            }
        }
    }
}
