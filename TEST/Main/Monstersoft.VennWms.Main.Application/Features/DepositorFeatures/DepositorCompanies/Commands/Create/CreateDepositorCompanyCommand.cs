using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;

public class CreateDepositorCompanyCommand : IRequest<CreatedDepositorCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositorCompanies";

    public CreateDepositorCompanyDto DepositorCompany { get; set; }
    public DepositorCompanyDetailLevel DetailLevel { get; set; }


    public class CreateDepositorCompanyCommandHandler : IRequestHandler<CreateDepositorCompanyCommand, CreatedDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public CreateDepositorCompanyCommandHandler(IDepositorCompanyRepository depositorCompanyRepository, DepositorCompanyBusinessRules depositorCompanyBusinessRules, IMapper mapper)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedDepositorCompanyResponse> Handle(CreateDepositorCompanyCommand request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.CreateRequest().CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.DepositorCompany.Code);

            DepositorCompany depositorCompany = _mapper.Map<DepositorCompany>(request.DepositorCompany);
            depositorCompany.Id = Guid.NewGuid();
            depositorCompany.CreatedDate = DateTime.Now;
            depositorCompany.Address.CreatedDate = DateTime.Now;

            await _depositorCompanyRepository.AddAsync(depositorCompany);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == depositorCompany.Id,
                include: x =>
                {
                    IQueryable<DepositorCompany> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }


                    var includableQuery = query as IIncludableQueryable<DepositorCompany, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDepositorCompanyResponse>(response);
            }
            else
            {
                var response = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == depositorCompany.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDepositorCompanyResponse>(response);

            }
        }
    }
}
