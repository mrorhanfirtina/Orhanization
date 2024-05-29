using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants.BranchOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Create;

public class CreateBranchCommand : IRequest<CreatedBranchResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBranches";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];

    public CreateBranchDto Branch { get; set; }
    public BranchDetailLevel DetailLevel { get; set; }


    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, CreatedBranchResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly BranchBusinessRules _branchBusinessRules;
        private readonly IMapper _mapper;

        public CreateBranchCommandHandler(IBranchRepository branchRepository, BranchBusinessRules branchBusinessRules, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _branchBusinessRules = branchBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedBranchResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            _branchBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.Branch.Code)
            .CheckDisturbitorIdExistence(request.Branch.DistributorId);

            Branch branch = _mapper.Map<Branch>(request.Branch);
            branch.Id = Guid.NewGuid();
            branch.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);
            branch.CreatedDate = DateTime.Now;

            await _branchRepository.AddAsync(branch);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _branchRepository.GetAsync(predicate: x => x.Id == branch.Id,
                include: x =>
                {
                    IQueryable<Branch> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.AddressId);
                    }

                    if (detailLevel.IncludeDistributor)
                    {
                        query = query.Include(y => y.Distributor);

                        if (detailLevel.DistributorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Distributor).ThenInclude(m => m.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Branch, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBranchResponse>(response);
            }
            else
            {
                var response = await _branchRepository.GetAsync(predicate: x => x.Id == branch.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBranchResponse>(response);
            }
        }
    }
}
