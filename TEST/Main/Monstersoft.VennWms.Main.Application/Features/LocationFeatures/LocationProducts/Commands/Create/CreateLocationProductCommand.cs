using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
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
    public string? CacheGroupKey => "GetLocationProducts";

    public CreateLocationProductDto LocationProduct { get; set; }


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

            return _mapper.Map<CreatedLocationProductResponse>(await _locationProductRepository.AddAsync(locationProduct));
        }
    }

}
