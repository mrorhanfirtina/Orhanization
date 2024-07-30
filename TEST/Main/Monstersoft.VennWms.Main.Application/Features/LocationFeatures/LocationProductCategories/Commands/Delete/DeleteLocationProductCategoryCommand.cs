using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants.LocationProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Delete;

public class DeleteLocationProductCategoryCommand : IRequest<DeletedLocationProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductCategoryOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductCategories"];

    public Guid Id { get; set; }

    public class DeleteLocationProductCategoryCommandHandler : IRequestHandler<DeleteLocationProductCategoryCommand, DeletedLocationProductCategoryResponse>
    {
        private readonly ILocationProductCategoryRepository _locationProductCategoryRepository;
        private readonly LocationProductCategoryBusinessRules _locationProductCategoryBusinessRules;

        public DeleteLocationProductCategoryCommandHandler(ILocationProductCategoryRepository locationProductCategoryRepository, LocationProductCategoryBusinessRules locationProductCategoryBusinessRules)
        {
            _locationProductCategoryRepository = locationProductCategoryRepository;
            _locationProductCategoryBusinessRules = locationProductCategoryBusinessRules;
        }

        public async Task<DeletedLocationProductCategoryResponse> Handle(DeleteLocationProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductCategoryBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductCategory locationProductCategory = await _locationProductCategoryRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationProductCategoryRepository.DeleteAsync(locationProductCategory);

            return new DeletedLocationProductCategoryResponse
            {
                Id = locationProductCategory.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationProductCategoryMessages.RequestExecutedSuccessfully
            };
        }
    }
}

