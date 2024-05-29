using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Update;

public class UpdateBranchCommand : IRequest<UpdatedBranchResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBranches";
    public string[] Roles => [Admin, User, Write, BranchOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateBranchDto Branch { get; set; }
    public BranchDetailLevel DetailLevel { get; set; }


    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand, UpdatedBranchResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly BranchBusinessRules _branchBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBranchCommandHandler(IBranchRepository branchRepository, BranchBusinessRules branchBusinessRules, IMapper mapper)
        {
            _branchRepository = branchRepository;
            _branchBusinessRules = branchBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedBranchResponse> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            _branchBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckIdExistence(request.Branch.Id)
                .CheckCodeExistenceWhenUpdate(request.Branch.Code, request.Branch.Id)
                .CheckDisturbitorIdExistence(request.Branch.DistributorId);

            Branch currentBranch = await _branchRepository.GetAsync(predicate: x => x.Id == request.Branch.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Branch? branch = _mapper.Map(request.Branch, currentBranch);
            branch.UpdatedDate = DateTime.Now;
            branch.Address.UpdatedDate = DateTime.Now;

            await _branchRepository.UpdateAsync(branch);

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

                return _mapper.Map<UpdatedBranchResponse>(response);
            }
            else
            {
                var response = await _branchRepository.GetAsync(predicate: x => x.Id == branch.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBranchResponse>(response);
            }
        }
    }
}
