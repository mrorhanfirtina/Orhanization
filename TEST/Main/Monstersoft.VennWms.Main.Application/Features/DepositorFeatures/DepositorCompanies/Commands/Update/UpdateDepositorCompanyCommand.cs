using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;

public class UpdateDepositorCompanyCommand : IRequest<UpdatedDepositorCompanyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, DepositorCompanyOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetDepositorCompanies"];

    public UpdateDepositorCompanyDto DepositorCompany { get; set; }
    public DepositorCompaniesDetailLevel DetailLevel { get; set; }


    public class UpdateDepositorCompanyCommandHandler : IRequestHandler<UpdateDepositorCompanyCommand, UpdatedDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateDepositorCompanyCommandHandler(IDepositorCompanyRepository depositorCompanyRepository, DepositorCompanyBusinessRules depositorCompanyBusinessRules, IMapper mapper)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedDepositorCompanyResponse> Handle(UpdateDepositorCompanyCommand request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.UpdateRequest().CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            DepositorCompany? currentDepositorCompany = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == request.DepositorCompany.Id,
                include: x => x.Include(y => y.Address));

            DepositorCompany? depositorCompany = _mapper.Map(request.DepositorCompany, currentDepositorCompany);
            depositorCompany.UpdatedDate = DateTime.Now;
            depositorCompany.Address.UpdatedDate = DateTime.Now;

            await _depositorCompanyRepository.UpdateAsync(depositorCompany);

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

                return _mapper.Map<UpdatedDepositorCompanyResponse>(response);
            }
            else
            {
                var response = await _depositorCompanyRepository.GetAsync(predicate: x => x.Id == depositorCompany.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedDepositorCompanyResponse>(response);

            }
        }
    }
}
