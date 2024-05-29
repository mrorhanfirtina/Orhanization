using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants.LocationProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Queries.GetById;

public class GetByIdLocationProductAbcCategoryQuery : IRequest<GetByIdLocationProductAbcCategoryResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationProductAbcCategoryDetailLevel DetailLevel { get; set; }

    public class GetByIdLocationProductAbcCategoryQueryHandler : IRequestHandler<GetByIdLocationProductAbcCategoryQuery, GetByIdLocationProductAbcCategoryResponse>
    {
        private readonly ILocationProductAbcCategoryRepository _locationProductAbcCategoryRepository;
        private readonly LocationProductAbcCategoryBusinessRules _locationProductAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationProductAbcCategoryQueryHandler(ILocationProductAbcCategoryRepository locationProductAbcCategoryRepository, IMapper mapper, LocationProductAbcCategoryBusinessRules locationProductAbcCategoryBusinessRules)
        {
            _locationProductAbcCategoryRepository = locationProductAbcCategoryRepository;
            _mapper = mapper;
            _locationProductAbcCategoryBusinessRules = locationProductAbcCategoryBusinessRules;
        }

        public async Task<GetByIdLocationProductAbcCategoryResponse> Handle(GetByIdLocationProductAbcCategoryQuery request, CancellationToken cancellationToken)
        {
            _locationProductAbcCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationProductAbcCategoryResponse>(await _locationProductAbcCategoryRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationProductAbcCategoryResponse>(await _locationProductAbcCategoryRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

