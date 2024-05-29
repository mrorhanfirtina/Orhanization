using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants.LocationProductConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Create;

public class CreateLocationProductConstraintCommand : IRequest<CreatedLocationProductConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProductConstraints";

    public CreateLocationProductConstraintDto LocationProductConstraint { get; set; }
    public LocationProductConstraintDetailLevel DetailLevel { get; set; }


    public class CreateLocationProductConstraintCommandHandler : IRequestHandler<CreateLocationProductConstraintCommand, CreatedLocationProductConstraintResponse>
    {
        private readonly ILocationProductConstraintRepository _locationProductConstraintRepository;
        private readonly LocationProductConstraintBusinessRules _locationProductConstraintBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationProductConstraintCommandHandler(ILocationProductConstraintRepository locationProductConstraintRepository, IMapper mapper, LocationProductConstraintBusinessRules locationProductConstraintBusinessRules)
        {
            _locationProductConstraintRepository = locationProductConstraintRepository;
            _mapper = mapper;
            _locationProductConstraintBusinessRules = locationProductConstraintBusinessRules;
        }

        public async Task<CreatedLocationProductConstraintResponse> Handle(CreateLocationProductConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationProductConstraintBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductConstraint locationProductConstraint = _mapper.Map<LocationProductConstraint>(request.LocationProductConstraint);
            locationProductConstraint.Id = Guid.NewGuid();
            locationProductConstraint.CreatedDate = DateTime.Now;

            await _locationProductConstraintRepository.AddAsync(locationProductConstraint);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == locationProductConstraint.Id,
                include: x =>
                {
                    IQueryable<LocationProductConstraint> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProductConstraint, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductConstraintResponse>(response);
            }
            else
            {
                var response = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == locationProductConstraint.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductConstraintResponse>(response);
            }
        }
    }
}

