using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants.LocationProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetById;

public class GetByIdLocationProductQuery : IRequest<GetByIdLocationProductResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdLocationProductQueryHandler : IRequestHandler<GetByIdLocationProductQuery, GetByIdLocationProductResponse>
    {
        private readonly ILocationProductRepository _locationProductRepository;
        private readonly LocationProductBusinessRules _locationProductBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLocationProductQueryHandler(ILocationProductRepository locationProductRepository, IMapper mapper, LocationProductBusinessRules locationProductBusinessRules)
        {
            _locationProductRepository = locationProductRepository;
            _mapper = mapper;
            _locationProductBusinessRules = locationProductBusinessRules;
        }

        public async Task<GetByIdLocationProductResponse> Handle(GetByIdLocationProductQuery request, CancellationToken cancellationToken)
        {
            _locationProductBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdLocationProductResponse>(await _locationProductRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }


}
