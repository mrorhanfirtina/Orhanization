using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants.LocationProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Update;

public class UpdateLocationProductCategoryCommand : IRequest<UpdatedLocationProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductCategoryOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductCategories"];

    public UpdateLocationProductCategoryDto LocationProductCategory { get; set; }
    public LocationProductCategoriesDetailLevel DetailLevel { get; set; }

    public class UpdateLocationProductCategoryCommandHandler : IRequestHandler<UpdateLocationProductCategoryCommand, UpdatedLocationProductCategoryResponse>
    {
        private readonly ILocationProductCategoryRepository _locationProductCategoryRepository;
        private readonly LocationProductCategoryBusinessRules _locationProductCategoryBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationProductCategoryCommandHandler(ILocationProductCategoryRepository locationProductCategoryRepository, LocationProductCategoryBusinessRules locationProductCategoryBusinessRules, IMapper mapper)
        {
            _locationProductCategoryRepository = locationProductCategoryRepository;
            _locationProductCategoryBusinessRules = locationProductCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationProductCategoryResponse> Handle(UpdateLocationProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductCategoryBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductCategory? currentLocationProductCategory = await _locationProductCategoryRepository.GetAsync(predicate: x => x.Id == request.LocationProductCategory.Id);

            LocationProductCategory? locationProductCategory = _mapper.Map(request.LocationProductCategory, currentLocationProductCategory);
            locationProductCategory.UpdatedDate = DateTime.Now;

            await _locationProductCategoryRepository.UpdateAsync(locationProductCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductCategoryRepository.GetAsync(predicate: x => x.Id == locationProductCategory.Id,
                include: x =>
                {
                    IQueryable<LocationProductCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeCategory)
                    {
                        query = query.Include(y => y.Category);
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProductCategory, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductCategoryResponse>(response);
            }
            else
            {
                var response = await _locationProductCategoryRepository.GetAsync(predicate: x => x.Id == locationProductCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductCategoryResponse>(response);
            }
        }
    }
}

