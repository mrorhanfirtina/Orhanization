using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants.LocationProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Commands.Create;

public class CreateLocationProductCategoryCommand : IRequest<CreatedLocationProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductCategories";

    public CreateLocationProductCategoryDto LocationProductCategory { get; set; }
    public LocationProductCategoriesDetailLevel DetailLevel { get; set; }


    public class CreateLocationProductCategoryCommandHandler : IRequestHandler<CreateLocationProductCategoryCommand, CreatedLocationProductCategoryResponse>
    {
        private readonly ILocationProductCategoryRepository _locationProductCategoryRepository;
        private readonly LocationProductCategoryBusinessRules _locationProductCategoryBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationProductCategoryCommandHandler(ILocationProductCategoryRepository locationProductCategoryRepository, IMapper mapper, LocationProductCategoryBusinessRules locationProductCategoryBusinessRules)
        {
            _locationProductCategoryRepository = locationProductCategoryRepository;
            _mapper = mapper;
            _locationProductCategoryBusinessRules = locationProductCategoryBusinessRules;
        }

        public async Task<CreatedLocationProductCategoryResponse> Handle(CreateLocationProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _locationProductCategoryBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductCategory locationProductCategory = _mapper.Map<LocationProductCategory>(request.LocationProductCategory);
            locationProductCategory.Id = Guid.NewGuid();
            locationProductCategory.CreatedDate = DateTime.Now;

            await _locationProductCategoryRepository.AddAsync(locationProductCategory);

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

                return _mapper.Map<CreatedLocationProductCategoryResponse>(response);
            }
            else
            {
                var response = await _locationProductCategoryRepository.GetAsync(predicate: x => x.Id == locationProductCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductCategoryResponse>(response);
            }
        }
    }
}

