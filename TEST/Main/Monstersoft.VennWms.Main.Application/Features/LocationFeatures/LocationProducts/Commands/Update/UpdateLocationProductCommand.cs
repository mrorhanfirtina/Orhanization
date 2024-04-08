using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Update;

public class UpdateLocationProductCommand : IRequest<UpdatedLocationProductResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationProductOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProducts";

    public UpdateLocationProductDto LocationProduct { get; set; }


    public class UpdateLocationProductCommandHandler : IRequestHandler<UpdateLocationProductCommand, UpdatedLocationProductResponse>
    {
        private readonly ILocationProductRepository _locationProductRepository;
        private readonly LocationProductBusinessRules _locationProductBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationProductCommandHandler(ILocationProductRepository locationProductRepository, LocationProductBusinessRules locationProductBusinessRules, IMapper mapper)
        {
            _locationProductRepository = locationProductRepository;
            _locationProductBusinessRules = locationProductBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationProductResponse> Handle(UpdateLocationProductCommand request, CancellationToken cancellationToken)
        {
            _locationProductBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.LocationProduct.Id)
            .CheckLocationIdExistence(request.LocationProduct.LocationId)
            .CheckProductIdExistence(request.LocationProduct.ProductId);

            LocationProduct? currentLocationProduct = await _locationProductRepository.GetAsync(predicate: x => x.Id == request.LocationProduct.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            LocationProduct? locationProduct = _mapper.Map(request.LocationProduct, currentLocationProduct);
            locationProduct.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedLocationProductResponse>(await _locationProductRepository.UpdateAsync(locationProduct));
        }
    }

}
