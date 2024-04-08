using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
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
                .CheckIdExistence(request.Branch.Id)
                .CheckAddressIdExistence(request.Branch.AddressId)
                .CheckCodeExistenceWhenUpdate(request.Branch.Code, request.Branch.Id)
                .CheckDisturbitorIdExistence(request.Branch.DistributorId);

            Branch currentBranch = await _branchRepository.GetAsync(predicate: x => x.Id == request.Branch.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Branch? branch = _mapper.Map(request.Branch, currentBranch);
            branch.UpdatedDate = DateTime.Now;
            branch.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedBranchResponse>(await _branchRepository.UpdateAsync(branch));
        }
    }
}
