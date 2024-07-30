using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants.LocationProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Delete;

public class DeleteLocationProductAbcCategoryCommand : IRequest<DeletedLocationProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductAbcCategoryOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductAbcCategorys"];

    public Guid Id { get; set; }

    public class DeleteLocationProductAbcCategoryCommandHandler : IRequestHandler<DeleteLocationProductAbcCategoryCommand, DeletedLocationProductAbcCategoryResponse>
    {
        private readonly ILocationProductAbcCategoryRepository _locationProductAbcCategoryRepository;
        private readonly LocationProductAbcCategoryBusinessRules _locationProductAbcCategoryBusinessRules;

        public DeleteLocationProductAbcCategoryCommandHandler(ILocationProductAbcCategoryRepository locationProductAbcCategoryRepository, LocationProductAbcCategoryBusinessRules locationProductAbcCategoryBusinessRules)
        {
            _locationProductAbcCategoryRepository = locationProductAbcCategoryRepository;
            _locationProductAbcCategoryBusinessRules = locationProductAbcCategoryBusinessRules;
        }

        public async Task<DeletedLocationProductAbcCategoryResponse> Handle(DeleteLocationProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductAbcCategoryBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductAbcCategory locationProductAbcCategory = await _locationProductAbcCategoryRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationProductAbcCategoryRepository.DeleteAsync(locationProductAbcCategory);

            return new DeletedLocationProductAbcCategoryResponse
            {
                Id = locationProductAbcCategory.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationProductAbcCategoryMessages.RequestExecutedSuccessfully
            };
        }
    }
}

