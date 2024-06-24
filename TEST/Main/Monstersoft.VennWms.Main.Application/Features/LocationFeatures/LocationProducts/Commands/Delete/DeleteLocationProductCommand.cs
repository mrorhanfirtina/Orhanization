using MediatR;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Delete;

public class DeleteLocationProductCommand : IRequest<DeletedLocationProductResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LocationProductOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationProducts";

    public Guid Id { get; set; }


    public class DeleteLocationProductCommandHandler : IRequestHandler<DeleteLocationProductCommand, DeletedLocationProductResponse>
    {
        private readonly ILocationProductRepository _locationProductRepository;
        private readonly LocationProductBusinessRules _locationProductBusinessRules;

        public DeleteLocationProductCommandHandler(ILocationProductRepository locationProductRepository, LocationProductBusinessRules locationProductBusinessRules)
        {
            _locationProductRepository = locationProductRepository;
            _locationProductBusinessRules = locationProductBusinessRules;
        }

        public async Task<DeletedLocationProductResponse> Handle(DeleteLocationProductCommand request, CancellationToken cancellationToken)
        {
            _locationProductBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationProduct locationProduct = await _locationProductRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationProductRepository.DeleteAsync(locationProduct);

            return new DeletedLocationProductResponse
            {
                Id = locationProduct.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationProductMessages.RequestExecutedSuccessfully
            };
        }
    }
}
