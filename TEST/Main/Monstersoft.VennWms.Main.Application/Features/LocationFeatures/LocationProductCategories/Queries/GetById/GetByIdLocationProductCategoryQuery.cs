using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants.LocationProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetById;

public class GetByIdLocationProductCategoryQuery : IRequest<GetByIdLocationProductCategoryResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationProductCategoryDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationProductCategoryQueryHandler : IRequestHandler<GetByIdLocationProductCategoryQuery, GetByIdLocationProductCategoryResponse>
    {
        private readonly ILocationProductCategoryRepository _locationProductCategoryRepository;
        private readonly LocationProductCategoryBusinessRules _locationProductCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationProductCategoryQueryHandler(ILocationProductCategoryRepository locationProductCategoryRepository, IMapper mapper, LocationProductCategoryBusinessRules locationProductCategoryBusinessRules)
        {
            _locationProductCategoryRepository = locationProductCategoryRepository;
            _mapper = mapper;
            _locationProductCategoryBusinessRules = locationProductCategoryBusinessRules;
        }

        public async Task<GetByIdLocationProductCategoryResponse> Handle(GetByIdLocationProductCategoryQuery request, CancellationToken cancellationToken)
        {
            _locationProductCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationProductCategoryResponse>(await _locationProductCategoryRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationProductCategoryResponse>(await _locationProductCategoryRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

