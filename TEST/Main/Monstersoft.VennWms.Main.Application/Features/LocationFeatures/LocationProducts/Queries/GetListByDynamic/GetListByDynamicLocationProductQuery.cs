using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants.LocationProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductQuery : IRequest<GetListResponse<GetListByDynamicLocationProductListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLocationProductQueryHandler : IRequestHandler<GetListByDynamicLocationProductQuery, GetListResponse<GetListByDynamicLocationProductListItemDto>>
    {
        private readonly ILocationProductRepository _locationProductRepository;
        private readonly LocationProductBusinessRules _locationProductBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationProductQueryHandler(ILocationProductRepository locationProductRepository, IMapper mapper, LocationProductBusinessRules locationProductBusinessRules)
        {
            _locationProductRepository = locationProductRepository;
            _locationProductBusinessRules = locationProductBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationProductListItemDto>> Handle(GetListByDynamicLocationProductQuery request, CancellationToken cancellationToken)
        {
            _locationProductBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<LocationProduct> locationProductList = await _locationProductRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLocationProductListItemDto>>(locationProductList);
        }
    }

}
