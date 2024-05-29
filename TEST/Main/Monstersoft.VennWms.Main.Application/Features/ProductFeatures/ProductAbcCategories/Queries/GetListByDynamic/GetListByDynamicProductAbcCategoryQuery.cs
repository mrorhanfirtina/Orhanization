using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants.ProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetListByDynamic;

public class GetListByDynamicProductAbcCategoryQuery : IRequest<GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ProductAbcCategoryDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicProductAbcCategoryQueryHandler : IRequestHandler<GetListByDynamicProductAbcCategoryQuery, GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>>
    {
        private readonly IProductAbcCategoryRepository _productAbcCategoryRepository;
        private readonly ProductAbcCategoryBusinessRules _productAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductAbcCategoryQueryHandler(IProductAbcCategoryRepository productAbcCategoryRepository, IMapper mapper, ProductAbcCategoryBusinessRules productAbcCategoryBusinessRules)
        {
            _productAbcCategoryRepository = productAbcCategoryRepository;
            _productAbcCategoryBusinessRules = productAbcCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>> Handle(GetListByDynamicProductAbcCategoryQuery request, CancellationToken cancellationToken)
        {
            _productAbcCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ProductAbcCategory> productAbcCategoryList = await _productAbcCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ProductAbcCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAbcCategoryList)
                    {
                        query = query.Include(y => y.AbcCategory);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }


                    var includableQuery = query as IIncludableQueryable<ProductAbcCategory, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>>(productAbcCategoryList);
            }
            else
            {
                Paginate<ProductAbcCategory> productAbcCategoryList = await _productAbcCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>>(productAbcCategoryList);
            }
        }
    }
}


