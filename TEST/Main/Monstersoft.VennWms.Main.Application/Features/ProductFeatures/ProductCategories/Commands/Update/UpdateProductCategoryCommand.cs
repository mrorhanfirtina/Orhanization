using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants.ProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Update;

public class UpdateProductCategoryCommand : IRequest<UpdatedProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductCategoryOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductCategories"];


    public UpdateProductCategoryDto ProductCategory { get; set; }
    public ProductCategoriesDetailLevel DetailLevel { get; set; }


    public class UpdateProductCategoryCommandHandler : IRequestHandler<UpdateProductCategoryCommand, UpdatedProductCategoryResponse>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly ProductCategoryBusinessRules _productCategoryBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductCategoryCommandHandler(IProductCategoryRepository productCategoryRepository, ProductCategoryBusinessRules productCategoryBusinessRules, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _productCategoryBusinessRules = productCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductCategoryResponse> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _productCategoryBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategory? currentProductCategory = await _productCategoryRepository.GetAsync(predicate: x => x.Id == request.ProductCategory.Id);

            ProductCategory? productCategory = _mapper.Map(request.ProductCategory, currentProductCategory);
            productCategory.UpdatedDate = DateTime.Now;

            await _productCategoryRepository.UpdateAsync(productCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productCategoryRepository.GetAsync(predicate: x => x.Id == productCategory.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductCategoryResponse>(response);
            }
            else
            {
                var response = await _productCategoryRepository.GetAsync(predicate: x => x.Id == productCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductCategoryResponse>(response);
            }
        }
    }
}

