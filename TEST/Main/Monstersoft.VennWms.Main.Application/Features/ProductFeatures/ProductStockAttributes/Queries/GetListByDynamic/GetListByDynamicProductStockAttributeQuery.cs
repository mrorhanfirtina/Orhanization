using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants.ProductStockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetListByDynamic;

public class GetListByDynamicProductStockAttributeQuery : IRequest<GetListResponse<GetListByDynamicProductStockAttributeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicProductStockAttributeQueryHandler : IRequestHandler<GetListByDynamicProductStockAttributeQuery, GetListResponse<GetListByDynamicProductStockAttributeListItemDto>>
    {
        private readonly IProductStockAttributeRepository _productStockAttributeRepository;
        private readonly ProductStockAttributeBusinessRules _productStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductStockAttributeQueryHandler(IProductStockAttributeRepository productStockAttributeRepository, IMapper mapper, ProductStockAttributeBusinessRules productStockAttributeBusinessRules)
        {
            _productStockAttributeRepository = productStockAttributeRepository;
            _productStockAttributeBusinessRules = productStockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductStockAttributeListItemDto>> Handle(GetListByDynamicProductStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _productStockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ProductStockAttribute> productStockAttributeList = await _productStockAttributeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicProductStockAttributeListItemDto>>(productStockAttributeList);
        }
    }
}

