using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants.LocationStockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Queries.GetById;

public class GetByIdLocationStockAttributeQuery : IRequest<GetByIdLocationStockAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public LocationStockAttributesDetailLevel DetailLevel { get; set; }


    public class GetByIdLocationStockAttributeQueryHandler : IRequestHandler<GetByIdLocationStockAttributeQuery, GetByIdLocationStockAttributeResponse>
    {
        private readonly ILocationStockAttributeRepository _locationStockAttributeRepository;
        private readonly LocationStockAttributeBusinessRules _locationStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationStockAttributeQueryHandler(ILocationStockAttributeRepository locationStockAttributeRepository, IMapper mapper, LocationStockAttributeBusinessRules locationStockAttributeBusinessRules)
        {
            _locationStockAttributeRepository = locationStockAttributeRepository;
            _mapper = mapper;
            _locationStockAttributeBusinessRules = locationStockAttributeBusinessRules;
        }

        public async Task<GetByIdLocationStockAttributeResponse> Handle(GetByIdLocationStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _locationStockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdLocationStockAttributeResponse>(await _locationStockAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false,
                include: x =>
                {
                    IQueryable<LocationStockAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        if (detailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<LocationStockAttribute, object>;
                    return includableQuery;
                },
                enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdLocationStockAttributeResponse>(await _locationStockAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false,
                enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

