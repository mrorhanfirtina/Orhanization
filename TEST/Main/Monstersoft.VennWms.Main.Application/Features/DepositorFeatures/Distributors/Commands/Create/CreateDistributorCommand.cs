using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Create;

public class CreateDistributorCommand : IRequest<CreatedDistributorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDisturbitors";

    public CreateDistributorDto Disturbitor { get; set; }
    public DistributorDetailLevel DetailLevel { get; set; }



    public class CreateDisturbitorCommandHandler : IRequestHandler<CreateDistributorCommand, CreatedDistributorResponse>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public CreateDisturbitorCommandHandler(IDistributorRepository disturbitorRepository, DistributorBusinessRules disturbitorBusinessRules, IMapper mapper)
        {
            _disturbitorRepository = disturbitorRepository;
            _disturbitorBusinessRules = disturbitorBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedDistributorResponse> Handle(CreateDistributorCommand request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.Disturbitor.Code)
            .CheckCompanyIdExistence(request.Disturbitor.CompanyId);

            Distributor disturbitor = _mapper.Map<Distributor>(request.Disturbitor);
            disturbitor.Id = Guid.NewGuid();
            disturbitor.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);
            disturbitor.CreatedDate = DateTime.Now;
            disturbitor.Address.CreatedDate = DateTime.Now;

            await _disturbitorRepository.AddAsync(disturbitor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _disturbitorRepository.GetAsync(predicate: x => x.Id == disturbitor.Id,
                include: x =>
                {
                    IQueryable<Distributor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeBranch)
                    {
                        query = query.Include(y => y.Branches);
                    }


                    var includableQuery = query as IIncludableQueryable<Distributor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDistributorResponse>(response);
            }
            else
            {
                var response = await _disturbitorRepository.GetAsync(predicate: x => x.Id == disturbitor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDistributorResponse>(response);

            }
        }
    }
}

