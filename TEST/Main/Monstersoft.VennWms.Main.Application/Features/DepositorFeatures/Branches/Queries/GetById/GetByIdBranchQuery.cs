using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants.BranchOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;

public class GetByIdBranchQuery : IRequest<GetByIdBranchResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }
    public BranchDetailLevel DetailLevel { get; set; }


    public class GetByIdBranchQueryHandler : IRequestHandler<GetByIdBranchQuery, GetByIdBranchResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly BranchBusinessRules _branchBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBranchQueryHandler(IBranchRepository branchRepository, IMapper mapper, BranchBusinessRules branchBusinessRules)
        {
            _branchRepository = branchRepository;
            _mapper = mapper;
            _branchBusinessRules = branchBusinessRules;
        }

        public async Task<GetByIdBranchResponse> Handle(GetByIdBranchQuery request, CancellationToken cancellationToken)
        {
            _branchBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdBranchResponse>(await _branchRepository.GetAsync(x => x.Id == request.Id,
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
                    },
                        withDeleted: false, enableTracking: false,
                        cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBranchResponse>(await _branchRepository.GetAsync(x => x.Id == request.Id,
                        withDeleted: false, enableTracking: false,
                        cancellationToken: cancellationToken));
            }

            
        }
    }

}
