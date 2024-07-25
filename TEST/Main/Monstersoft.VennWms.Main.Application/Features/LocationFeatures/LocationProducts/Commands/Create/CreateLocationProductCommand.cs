using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants.LocationProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Create;

public class CreateLocationProductCommand : IRequest<CreatedLocationProductResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProducts"];

    public CreateLocationProductDto LocationProduct { get; set; }
    public LocationProductsDetailLevel DetailLevel { get; set; }


    public class CreateLocationProductCommandHandler : IRequestHandler<CreateLocationProductCommand, CreatedLocationProductResponse>
    {
        private readonly ILocationProductRepository _locationProductRepository;
        private readonly LocationProductBusinessRules _locationProductBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationProductCommandHandler(ILocationProductRepository locationProductRepository, IMapper mapper, LocationProductBusinessRules locationProductBusinessRules)
        {
            _locationProductRepository = locationProductRepository;
            _mapper = mapper;
            _locationProductBusinessRules = locationProductBusinessRules;
        }

        public async Task<CreatedLocationProductResponse> Handle(CreateLocationProductCommand request, CancellationToken cancellationToken)
        {
            _locationProductBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckLocationIdExistence(request.LocationProduct.LocationId)
                .CheckProductIdExistence(request.LocationProduct.ProductId);

            LocationProduct locationProduct = _mapper.Map<LocationProduct>(request.LocationProduct);
            locationProduct.Id = Guid.NewGuid();
            locationProduct.CreatedDate = DateTime.Now;

            await _locationProductRepository.AddAsync(locationProduct);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationProductRepository.GetAsync(predicate: x => x.Id == locationProduct.Id,
                include: x =>
                {
                    IQueryable<LocationProduct> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    var includableQuery = query as IIncludableQueryable<LocationProduct, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductResponse>(response);
            }
            else
            {
                var response = await _locationProductRepository.GetAsync(predicate: x => x.Id == locationProduct.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationProductResponse>(response);
            }
        }
    }

}
