using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants.ProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Queries.GetListByDynamic;

public class GetListByDynamicProductCategoryQuery : IRequest<GetListResponse<GetListByDynamicProductCategoryListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ProductCategoryDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicProductCategoryQueryHandler : IRequestHandler<GetListByDynamicProductCategoryQuery, GetListResponse<GetListByDynamicProductCategoryListItemDto>>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly ProductCategoryBusinessRules _productCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductCategoryQueryHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper, ProductCategoryBusinessRules productCategoryBusinessRules)
        {
            _productCategoryRepository = productCategoryRepository;
            _productCategoryBusinessRules = productCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductCategoryListItemDto>> Handle(GetListByDynamicProductCategoryQuery request, CancellationToken cancellationToken)
        {
            _productCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ProductCategory> productCategoryList = await _productCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ProductCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeCategory)
                    {
                        query = query.Include(y => y.Category);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductCategory, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductCategoryListItemDto>>(productCategoryList);
            }
            else
            {
                Paginate<ProductCategory> productCategoryList = await _productCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductCategoryListItemDto>>(productCategoryList);
            }
        }
    }
}

