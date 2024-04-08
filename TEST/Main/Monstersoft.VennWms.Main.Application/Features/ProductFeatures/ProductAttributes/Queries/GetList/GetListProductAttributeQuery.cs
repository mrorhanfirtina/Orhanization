using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants.ProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetList;

public class GetListProductAttributeQuery : IRequest<GetListResponse<GetListProductAttributeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListProductAttributeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetProductAttributes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListProductAttributeQueryHandler : IRequestHandler<GetListProductAttributeQuery, GetListResponse<GetListProductAttributeListItemDto>>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListProductAttributeQueryHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper, ProductAttributeBusinessRules productAttributeBusinessRules)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
            _productAttributeBusinessRules = productAttributeBusinessRules;
        }

        public async Task<GetListResponse<GetListProductAttributeListItemDto>> Handle(GetListProductAttributeQuery request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ProductAttribute> productAttributeList = await _productAttributeRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListProductAttributeListItemDto>>(productAttributeList);
        }
    }
}
