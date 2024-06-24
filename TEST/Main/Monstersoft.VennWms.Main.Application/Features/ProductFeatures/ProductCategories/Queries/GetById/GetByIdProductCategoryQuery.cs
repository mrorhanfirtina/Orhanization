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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants.ProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories;

public class GetByIdProductCategoryQuery : IRequest<GetByIdProductCategoryResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, ProductCategoryOperationClaims.User, Read];

    public Guid Id { get; set; }
    public ProductCategoriesDetailLevel DetailLevel { get; set; }


    public class GetByIdProductCategoryQueryHandler : IRequestHandler<GetByIdProductCategoryQuery, GetByIdProductCategoryResponse>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly ProductCategoryBusinessRules _productCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductCategoryQueryHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper, ProductCategoryBusinessRules productCategoryBusinessRules)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
            _productCategoryBusinessRules = productCategoryBusinessRules;
        }

        public async Task<GetByIdProductCategoryResponse> Handle(GetByIdProductCategoryQuery request, CancellationToken cancellationToken)
        {
            _productCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdProductCategoryResponse>(await _productCategoryRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdProductCategoryResponse>(await _productCategoryRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

