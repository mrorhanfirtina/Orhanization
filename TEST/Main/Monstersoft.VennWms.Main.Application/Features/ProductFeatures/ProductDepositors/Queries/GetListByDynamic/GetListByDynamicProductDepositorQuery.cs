using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants.ProductDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Queries.GetListByDynamic;

public class GetListByDynamicProductDepositorQuery : IRequest<GetListResponse<GetListByDynamicProductDepositorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicProductDepositorQueryHandler : IRequestHandler<GetListByDynamicProductDepositorQuery, GetListResponse<GetListByDynamicProductDepositorListItemDto>>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductDepositorQueryHandler(IProductDepositorRepository productDepositorRepository, IMapper mapper, ProductDepositorBusinessRules productDepositorBusinessRules)
        {
            _productDepositorRepository = productDepositorRepository;
            _productDepositorBusinessRules = productDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductDepositorListItemDto>> Handle(GetListByDynamicProductDepositorQuery request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ProductDepositor> productDepositorList = await _productDepositorRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicProductDepositorListItemDto>>(productDepositorList);
        }
    }

}


