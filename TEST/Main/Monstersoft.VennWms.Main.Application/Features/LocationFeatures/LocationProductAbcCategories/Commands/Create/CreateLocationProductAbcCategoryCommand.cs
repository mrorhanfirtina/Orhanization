using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Create;

public class CreateLocationProductAbcCategoryCommand : IRequest<CreatedLocationProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductAbcCategorys"];

    public CreateLocationProductAbcCategoryDto LocationProductAbcCategory { get; set; }
    public LocationProductAbcCategoriesDetailLevel DetailLevel { get; set; }


    public class CreateLocationProductAbcCategoryCommandHandler : IRequestHandler<CreateLocationProductAbcCategoryCommand, CreatedLocationProductAbcCategoryResponse>
    {
        private readonly ILocationProductAbcCategoryRepository _locationProductAbcCategoryRepository;
        private readonly LocationProductAbcCategoryBusinessRules _locationProductAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationProductAbcCategoryCommandHandler(ILocationProductAbcCategoryRepository locationProductAbcCategoryRepository, IMapper mapper, LocationProductAbcCategoryBusinessRules locationProductAbcCategoryBusinessRules)
        {
            _locationProductAbcCategoryRepository = locationProductAbcCategoryRepository;
            _mapper = mapper;
            _locationProductAbcCategoryBusinessRules = locationProductAbcCategoryBusinessRules;
        }

        public async Task<CreatedLocationProductAbcCategoryResponse> Handle(CreateLocationProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductAbcCategoryBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductAbcCategory locationProductAbcCategory = _mapper.Map<LocationProductAbcCategory>(request.LocationProductAbcCategory);
            locationProductAbcCategory.Id = Guid.NewGuid();
            locationProductAbcCategory.CreatedDate = DateTime.Now;

            await _locationProductAbcCategoryRepository.AddAsync(locationProductAbcCategory);

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

                return _mapper.Map<CreatedLocationProductAbcCategoryResponse>(response);
            }
            else
            {
                var response = await _locationProductAbcCategoryRepository.GetAsync(predicate: x => x.Id == locationProductAbcCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductAbcCategoryResponse>(response);
            }
        }
    }
}

