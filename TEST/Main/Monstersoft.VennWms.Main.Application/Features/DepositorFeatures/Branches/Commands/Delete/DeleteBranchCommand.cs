using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants.BranchOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Delete;

public class DeleteBranchCommand : IRequest<DeletedBranchResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBranches";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, BranchOperationClaims.Delete];

    public Guid Id { get; set; }


    public class DeleteBranchCommandHandler : IRequestHandler<DeleteBranchCommand, DeletedBranchResponse>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly BranchBusinessRules _branchBusinessRules;
        private readonly IAddressRepository _addressRepository;

        public DeleteBranchCommandHandler(IBranchRepository branchRepository, BranchBusinessRules branchBusinessRules, IAddressRepository addressRepository)
        {
            _branchRepository = branchRepository;
            _branchBusinessRules = branchBusinessRules;
            _addressRepository = addressRepository;
        }

        public async Task<DeletedBranchResponse> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            _branchBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Branch branch = await _branchRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _branchRepository.DeleteAsync(branch);
            await _addressRepository.DeleteAsync(branch.Address);

            return new DeletedBranchResponse
            {
                Id = branch.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BranchMessages.RequestExecutedSuccessfully
            };
        }
    }

}
