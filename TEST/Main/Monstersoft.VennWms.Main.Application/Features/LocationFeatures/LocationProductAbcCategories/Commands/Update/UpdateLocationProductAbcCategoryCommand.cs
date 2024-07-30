using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants.LocationProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Update;

public class UpdateLocationProductAbcCategoryCommand : IRequest<UpdatedLocationProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductAbcCategoryOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductAbcCategorys"];

    public UpdateLocationProductAbcCategoryDto LocationProductAbcCategory { get; set; }
    public LocationProductAbcCategoriesDetailLevel DetailLevel { get; set; }

    public class UpdateLocationProductAbcCategoryCommandHandler : IRequestHandler<UpdateLocationProductAbcCategoryCommand, UpdatedLocationProductAbcCategoryResponse>
    {
        private readonly ILocationProductAbcCategoryRepository _locationProductAbcCategoryRepository;
        private readonly LocationProductAbcCategoryBusinessRules _locationProductAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationProductAbcCategoryCommandHandler(ILocationProductAbcCategoryRepository locationProductAbcCategoryRepository, LocationProductAbcCategoryBusinessRules locationProductAbcCategoryBusinessRules, IMapper mapper)
        {
            _locationProductAbcCategoryRepository = locationProductAbcCategoryRepository;
            _locationProductAbcCategoryBusinessRules = locationProductAbcCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationProductAbcCategoryResponse> Handle(UpdateLocationProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductAbcCategoryBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductAbcCategory? currentLocationProductAbcCategory = await _locationProductAbcCategoryRepository.GetAsync(predicate: x => x.Id == request.LocationProductAbcCategory.Id);

            LocationProductAbcCategory? locationProductAbcCategory = _mapper.Map(request.LocationProductAbcCategory, currentLocationProductAbcCategory);
            locationProductAbcCategory.UpdatedDate = DateTime.Now;

            await _locationProductAbcCategoryRepository.UpdateAsync(locationProductAbcCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductAbcCategoryRepository.GetAsync(predicate: x => x.Id == locationProductAbcCategory.Id,
                include: x =>
                {
                    IQueryable<LocationProductAbcCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeAbcCategory)
                    {
                        query = query.Include(y => y.AbcCategory);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationProductAbcCategory, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductAbcCategoryResponse>(response);
            }
            else
            {
                var response = await _locationProductAbcCategoryRepository.GetAsync(predicate: x => x.Id == locationProductAbcCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationProductAbcCategoryResponse>(response);
            }
        }
    }
}

