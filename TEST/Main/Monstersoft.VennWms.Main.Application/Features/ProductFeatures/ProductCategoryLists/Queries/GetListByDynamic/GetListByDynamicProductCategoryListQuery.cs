﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants.ProductCategoryListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetListByDynamic;

public class GetListByDynamicProductCategoryListQuery : IRequest<GetListResponse<GetListByDynamicProductCategoryListListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ProductCategoryListDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicProductCategoryListQueryHandler : IRequestHandler<GetListByDynamicProductCategoryListQuery, GetListResponse<GetListByDynamicProductCategoryListListItemDto>>
    {
        private readonly IProductCategoryListRepository _productCategoryListRepository;
        private readonly ProductCategoryListBusinessRules _productCategoryListBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductCategoryListQueryHandler(IProductCategoryListRepository productCategoryListRepository, IMapper mapper, ProductCategoryListBusinessRules productCategoryListBusinessRules)
        {
            _productCategoryListRepository = productCategoryListRepository;
            _productCategoryListBusinessRules = productCategoryListBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductCategoryListListItemDto>> Handle(GetListByDynamicProductCategoryListQuery request, CancellationToken cancellationToken)
        {
            _productCategoryListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ProductCategoryList> productCategoryListList = await _productCategoryListRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ProductCategoryList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductCategoryList, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductCategoryListListItemDto>>(productCategoryListList);
            }
            else
            {
                Paginate<ProductCategoryList> productCategoryListList = await _productCategoryListRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductCategoryListListItemDto>>(productCategoryListList);
            }
        }
    }
}

