using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;

public class CreateDepositorCommand : IRequest<CreatedDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDepositors";

    public CreateDepositorDto Depositor { get; set; }
    public DepositorsDetailLevel DetailLevel { get; set; }


    public class CreateDepositorCommandHandler : IRequestHandler<CreateDepositorCommand, CreatedDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateDepositorCommandHandler(IDepositorRepository depositorRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules)
        {
            _depositorRepository = depositorRepository;
            _mapper = mapper;
            _depositorBusinessRules = depositorBusinessRules;
        }

        public async Task<CreatedDepositorResponse> Handle(CreateDepositorCommand request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Depositor.Code)
                .CheckDepositorCompanyIdExistence();

            Depositor depositor = _mapper.Map<Depositor>(request.Depositor);
            depositor.Id = Guid.NewGuid();
            depositor.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            depositor.CreatedDate = DateTime.Now;
            depositor.DepositorFeature.CreatedDate = DateTime.Now;

            await _depositorRepository.AddAsync(depositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _depositorRepository.GetAsync(predicate: x => x.Id == depositor.Id,
                include: x =>
                {
                    IQueryable<Depositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeDepositorFeature)
                    {
                        query = query.Include(y => y.DepositorFeature);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);

                        if (detailLevel.CompanyDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Company).ThenInclude(m => m.Address);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Depositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDepositorResponse>(response);
            }
            else
            {
                var response = await _depositorRepository.GetAsync(predicate: x => x.Id == depositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedDepositorResponse>(response);

            }
        }
    }

}
